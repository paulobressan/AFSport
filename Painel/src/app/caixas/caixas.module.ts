import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CaixasRoutingModule } from './caixas.routing.module';
import { CaixaService } from './caixa/caixa.service';
import { CaixaListResolve } from './caixa-list/caixa-list.resolve';
import { CaixaListModule } from './caixa-list/caixa-list.module';
import { CaixaFormModule } from './caixa-form/caixa-form.module';
import { CaixaFormResolve } from './caixa-form/caixa-form.resolve';

@NgModule({
  imports: [
    CommonModule,
    CaixasRoutingModule,
    CaixaListModule,
    CaixaFormModule
  ],
  providers: [
    CaixaService,
    CaixaListResolve,
    CaixaFormResolve
  ]
})
export class CaixasModule { }
