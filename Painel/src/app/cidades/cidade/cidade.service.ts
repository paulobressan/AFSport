import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';

import { BaseService } from '../../core/base/base.service';
import { Cidade } from './cidade';

@Injectable()
export class CidadeService extends BaseService<Cidade> {
    constructor(private httpClient: HttpClient) {
        super(httpClient, environment.cidade);
    }

    listarAtivas() {
        return this.http.get<Cidade[]>(`${environment.cidade}/ativas`);
    }
}