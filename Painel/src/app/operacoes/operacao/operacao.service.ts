import { Injectable } from '@angular/core';
import { BaseService } from 'src/app/core/base/base.service';
import { Operacao } from './operacao';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';

@Injectable()
export class OperacaoService extends BaseService<Operacao>{
    constructor(httpClient: HttpClient) {
        super(httpClient, environment.operacao);
    }
}