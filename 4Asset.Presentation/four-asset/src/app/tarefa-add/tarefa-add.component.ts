import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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
  selector: 'app-tarefa-add',
  templateUrl: './tarefa-add.component.html',
  styleUrls: ['./tarefa-add.component.css']
})
export class TarefaAddComponent implements OnInit {

  tarefaForm: FormGroup;
  titulo = '';
  descricao = '';
  status: false;
  isLoadingResults = false;
  matcher = new MyErrorStateMatcher();

  constructor(private router: Router, private api: ApiService, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.tarefaForm = this.formBuilder.group({
      'titulo' : [null, Validators.required],
      'descricao' : [null, Validators.required],
      'status' : [null, Validators.nullValidator]
    });
  }

  onFormSubmit() {
    this.isLoadingResults = true;
    this.api.addTarefa(this.tarefaForm.value)
      .subscribe((res: any) => {
          const id = res.tarefaId;
          this.isLoadingResults = false;
          this.router.navigate(['/tarefa-details', id]);
        }, (err: any) => {
          console.log(err);
          this.isLoadingResults = false;
        });
  }
}
