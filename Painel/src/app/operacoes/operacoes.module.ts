import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OperacoesRoutingModule } from './operacoes.routing.module';
import { OperacaoListModule } from './operacao-list/operacao-list.module';
import { OperacaoService } from './operacao/operacao.service';
import { OperacaoListResolve } from './operacao-list/operacao-list.resolve';
import { OperacaoFormModule } from './operacao-form/operacao-form.module';
import { OperacaoFormResolve } from './operacao-form/operacao-form.resolve';

@NgModule({
    imports: [
        CommonModule,
        OperacoesRoutingModule,
        OperacaoListModule,
        OperacaoFormModule
    ],
    providers: [
        OperacaoService,
        OperacaoListResolve,
        OperacaoFormResolve
    ]
})
export class OperacoesModule { }