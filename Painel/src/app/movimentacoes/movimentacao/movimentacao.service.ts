import { Injectable } from '@angular/core';
import { BaseService } from 'src/app/core/base/base.service';
import { Movimentacao } from './movimentacao';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable()
export class MovimentacaoService extends BaseService<Movimentacao>{
  constructor(httpClient: HttpClient) {
    super(httpClient, environment.movimentacao);
  }
}
