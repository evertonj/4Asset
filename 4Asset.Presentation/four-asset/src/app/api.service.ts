import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { Tarefa } from './tarefa';

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json',
  'Access-Control-Allow-Origin': '*',
  'Access-Control-Allow-Methods': 'GET, POST, PATCH, PUT, DELETE, OPTIONS',
  'Access-Control-Allow-Headers': 'Origin, Content-Type, X-Auth-Token'})
};

const apiUrl = 'http://127.0.0.1:5000/api/tarefas'

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http:HttpClient) { }

  getTarefas(): Observable<Tarefa[]> {
    return this.http.get<Tarefa[]>(apiUrl)
      .pipe(
        tap(tarefa => console.log('fetched tarefas')),
        catchError(this.handleError('getTarefas', []))
      );
  }

  getTarefa(id: number): Observable<Tarefa> {
    const url = `${apiUrl}/${id}`;
    return this.http.get<Tarefa>(url).pipe(
      tap(_ => console.log(`fetched tarefa id=${id}`)),
      catchError(this.handleError<Tarefa>(`gettarefa id=${id}`))
    );
  }

  addTarefa(tarefa: Tarefa): Observable<Tarefa> {
    return this.http.post<Tarefa>(apiUrl, tarefa, httpOptions).pipe(
      tap((tarefa: any) => console.log(`added tarefa w/ id=${tarefa._id}`)),
      catchError(this.handleError<Tarefa>('addtarefa'))
    );
  }

  updateTarefa(id: any, tarefa: Tarefa): Observable<any> {
    const url = `${apiUrl}/${id}`;
    return this.http.put(url, tarefa, httpOptions).pipe(
      tap(_ => console.log(`updated tarefa id=${id}`)),
      catchError(this.handleError<any>('updatetarefa'))
    );
  }

  deleteTarefa(id: any): Observable<Tarefa> {
    const url = `${apiUrl}/${id}`;
    return this.http.delete<Tarefa>(url, httpOptions).pipe(
      tap(_ => console.log(`deleted tarefa id=${id}`)),
      catchError(this.handleError<Tarefa>('deletetarefa'))
    );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      console.error(error);

      return of(result as T);
    };
  }
}
