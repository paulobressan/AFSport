import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../../environments/environment';
import { Categoria } from './categoria';
import { Observable } from 'rxjs';
import { BaseService } from '../../core/base/base.service';


@Injectable()
export class CategoriaService extends BaseService<Categoria> {
    constructor(private httpClient: HttpClient) {
        super(httpClient, environment.categoria);
    }

    listarAtivos() : Observable<Categoria[]> {
        return this.http.get<Categoria[]>(`${environment.categoria}/ativas`);
    }
}