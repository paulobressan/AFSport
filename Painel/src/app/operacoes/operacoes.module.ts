import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OperacoesRoutingModule } from './operacoes.routing.module';
import { OperacaoListModule } from './operacao-list/operacao-list.module';
import { OperacaoService } from './operacao/operacao.service';
import { OperacaoListResolve } from './operacao-list/operacao-list.resolve';

@NgModule({
    imports: [
        CommonModule,
        OperacoesRoutingModule,
        OperacaoListModule
    ],
    providers: [
        OperacaoService,
        OperacaoListResolve
    ]
})
export class OperacoesModule { }