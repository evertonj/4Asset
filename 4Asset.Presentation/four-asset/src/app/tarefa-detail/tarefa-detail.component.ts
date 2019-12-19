import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from '../api.service';
import { Tarefa } from '../tarefa';

@Component({
  selector: 'app-tarefa-detail',
  templateUrl: './tarefa-detail.component.html',
  styleUrls: ['./tarefa-detail.component.css']
})
export class TarefaDetailComponent implements OnInit {

  tarefa: Tarefa = { _id: '', titulo: '', descricao: '', status: null, dataCriacao: null,dataEdicao:null,dataConclusao:null,dataRemocao:null };
  isLoadingResults = true;

  constructor(private route: ActivatedRoute, private api: ApiService, private router: Router) { }

  ngOnInit() {
    this.getTarefaDetails(this.route.snapshot.params['id']);
  }

  getTarefaDetails(id: any) {
    this.api.getTarefa(id)
      .subscribe((data: any) => {
        this.tarefa = data;
        console.log(this.tarefa);
        this.isLoadingResults = false;
      });
  }

  deleteTarefa(id: any) {
    this.isLoadingResults = true;
    this.api.deleteTarefa(id)
      .subscribe(res => {
          this.isLoadingResults = false;
          this.router.navigate(['/tarefas']);
        }, (err) => {
          console.log(err);
          this.isLoadingResults = false;
        }
      );
  }

}
