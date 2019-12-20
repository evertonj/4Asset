import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ApiService } from '../api.service';
import { FormControl, FormGroupDirective, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';

export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}

@Component({
  selector: 'app-tarefa-edit',
  templateUrl: './tarefa-edit.component.html',
  styleUrls: ['./tarefa-edit.component.css']
})
export class TarefaEditComponent implements OnInit {
  tarefaForm: FormGroup;
  tarefaId = '';
  titulo = '';
  descricao = '';
  status: false;
  isLoadingResults = false;
  matcher = new MyErrorStateMatcher();

  constructor(private router: Router, private route: ActivatedRoute, private api: ApiService, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.getTarefa(this.route.snapshot.params['id']);
    this.tarefaForm = this.formBuilder.group({
      'titulo' : [null, Validators.required],
      'descricao' : [null, Validators.required],
      'status' : [null, Validators.required]
    });
  }

  getTarefa(id: any) {
    this.api.getTarefa(id).subscribe((data: any) => {
      this.tarefaId = data.tarefaId;
      this.tarefaForm.setValue({
        titulo: data.titulo,
        descricao: data.descricao,
        status: data.status
      });
    });
  }

  onFormSubmit() {
    this.isLoadingResults = true;
    this.api.updateTarefa(this.tarefaId, this.tarefaForm.value)
      .subscribe((res: any) => {
          const id = res.tarefaId;
          this.isLoadingResults = false;
          this.router.navigate(['/tarefa-details', id]);
        }, (err: any) => {
          console.log(err);
          this.isLoadingResults = false;
        }
      );
  }

  tarefaDetails() {
    this.router.navigate(['/tarefa-details', this.tarefaId]);
  }
}
