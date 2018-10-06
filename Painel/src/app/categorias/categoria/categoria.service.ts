import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../../environments/environment';
import { Categoria } from './categoria';
import { Observable } from 'rxjs';


@Injectable()
export class CategoriaService {
    constructor(private http: HttpClient) {
    }

    listarCategorias(): Observable<Categoria[]> {
        return this.http.get<Categoria[]>(environment.categoria);
    }

    inserir(categoria: Categoria): Observable<Categoria> {
        return this.http.post<Categoria>(environment.categoria, categoria);
    }

    alterar(categoria: Categoria): Observable<Categoria> {
        return this.http.put<Categoria>(`${environment.categoria}/${categoria.idCategoria}`, categoria);
    }

    selecionarCategoriaPorId(id: number): Observable<Categoria> {
        return this.http.get<Categoria>(`${environment.categoria}/${id}`);
    }

    remover(id: number): Observable<any> {
        return this.http.delete(`${environment.categoria}/${id}`);
    }
}