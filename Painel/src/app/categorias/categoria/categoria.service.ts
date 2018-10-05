import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../../environments/environment';
import { Categoria } from './categoria';


@Injectable()
export class CategoriaService {
    constructor(private http: HttpClient) {
    }

    listarCategorias() {
        return this.http.get<Categoria[]>(environment.categoria);
    }

    inserir(categoria: Categoria) {
        return this.http.post<Categoria>(environment.categoria, categoria);
    }
}