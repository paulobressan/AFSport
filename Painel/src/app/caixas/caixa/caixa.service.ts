import { Injectable } from '@angular/core';
import { BaseService } from '../../core/base/base.service';
import { Caixa } from './caixa';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';

@Injectable()
export class CaixaService extends BaseService<Caixa>{
  constructor(httpClient: HttpClient) {
    super(httpClient, environment.caixa)
  }
}
