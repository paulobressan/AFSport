import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MovimentacaoService } from './movimentacao/movimentacao.service';
import { MovimentacaoListModule } from './movimentacao-list/movimentacao-list.module';
import { MovimentacaoListResolve } from './movimentacao-list/movimentacao-list.resolve';
import { MovimentacoesRoutingModule } from './movimentacoes.routing.module';

@NgModule({
    imports: [
        CommonModule,
        MovimentacoesRoutingModule,
        MovimentacaoListModule
    ],
    providers: [
        MovimentacaoService,
        MovimentacaoListResolve
    ]
})
export class MovimentacoesModule { }