import { Component, OnInit } from '@angular/core';
import {ApiService} from '../api.service';
import {Tarefa} from '../tarefa';

@Component({
  selector: 'app-tarefas',
  templateUrl: './tarefas.component.html',
  styleUrls: ['./tarefas.component.css']
})
export class TarefasComponent implements OnInit {

  displayedColumns: string[] = ['titulo','descricao', 'status'];
  data: Tarefa[] = [];
  isLoadingResults = true;

  constructor(private api:ApiService) { }

  ngOnInit() {
    this.api.getTarefas()
    .subscribe((res: any) => {
      this.data = res;
      console.log(this.data);
      this.isLoadingResults = false;
    }, err => {
      console.log(err);
      this.isLoadingResults = false;
    });
  }

}
