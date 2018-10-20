import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EstoqueService } from './estoque/estoque.service';
import { EstoqueListResolve } from './estoque-list/estoque-list.resolve';
import { EstoqueListModule } from './estoque-list/estoque-list.module';
import { EstoquesRoutingModule } from './estoques.routing.module';
import { ProdutoService } from '../produtos/produto/produto.service';
import { ProdutoSemEstoqueResolve } from '../produtos/produto/produto-sem-estoque.resolve';
import { EstoqueFormResolve } from './estoque-form/estoque-form.resolve';
import { EstoqueFormModule } from './estoque-form/estoque-form.module';
import { ProdutoComEstoqueResolve } from '../produtos/produto/produto-com-estoque.resolve';

@NgModule({
    imports: [
        CommonModule,
        EstoquesRoutingModule,
        EstoqueListModule,
        EstoqueFormModule
    ],
    providers: [
        EstoqueService,
        EstoqueListResolve,
        EstoqueFormResolve,
        ProdutoService,
        ProdutoSemEstoqueResolve,
        ProdutoComEstoqueResolve
    ]
})
export class EstoquesModule { }