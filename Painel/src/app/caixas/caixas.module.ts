import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CaixasRoutingModule } from './caixas.routing.module';
import { CaixaService } from './caixa/caixa.service';
import { CaixaListResolve } from './caixa-list/caixa-list.resolve';
import { CaixaListModule } from './caixa-list/caixa-list.module';

@NgModule({
  imports: [
    CommonModule,
    CaixasRoutingModule,
    CaixaListModule
  ],
  providers: [
    CaixaService,
    CaixaListResolve
  ]
})
export class CaixasModule { }
