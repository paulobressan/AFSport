import { Injectable } from '@angular/core';
import { BaseService } from '../../core/base/base.service';
import { Cliente } from './cliente';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';

@Injectable()
export class ClienteService extends BaseService<Cliente> {
    constructor(private httpClient: HttpClient) {
        super(httpClient, environment.cliente);
    }

    listarAtivos(): Observable<Cliente[]> {
        return this.http.get<Cliente[]>(`${this.environment}/ativos`);
    }
}