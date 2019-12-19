import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {TarefasComponent} from './tarefas/tarefas.component';
import {TarefaAddComponent} from './tarefa-add/tarefa-add.component';
import {TarefaEditComponent} from './tarefa-edit/tarefa-edit.component';
import {TarefaDetailComponent} from './tarefa-detail/tarefa-detail.component';



const routes: Routes = [
  {
    path:'tarefas',
    component:TarefasComponent,
    data:{title:'Lista de tarefas'}
  },
  {
    path:'tarefas-add',
    component:TarefaAddComponent,
    data:{title:'Adicionar tarefa'}
  },
  {
    path:'tarefas-edit/:id',
    component:TarefaEditComponent,
    data:{title:'Alterar tarefa'}
  },
  {
    path:'tarefas-details/:id',
    component:TarefaDetailComponent,
    data:{title:'Detalhes da tarefa'}
  },
  {
    path:'',
    redirectTo:'/tarefas',
    pathMatch:'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
