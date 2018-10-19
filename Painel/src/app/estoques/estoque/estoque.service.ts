import { Injectable } from '@angular/core';
import { BaseService } from 'src/app/core/base/base.service';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Estoque } from './estoque';

@Injectable()
export class EstoqueService extends BaseService<Estoque> {
  constructor(httpClient: HttpClient) {
    super(httpClient, environment.estoque);
  }

  gerarEstoque(idProduto: number) {

  }
}
