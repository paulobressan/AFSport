import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { ProdutoListComponent } from './produto-list.component';
import { IsAtivoModule } from '../../shared/components/is-ativo/is-ativo.module';
import { ProdutoGerarEstoqueComponent } from '../produto-gerar-estoque/produto-gerar-estoque.component';
import { EstoqueService } from '../../estoques/estoque/estoque.service';

@NgModule({
    declarations: [ProdutoListComponent, ProdutoGerarEstoqueComponent],
    imports: [
        CommonModule,
        RouterModule,
        IsAtivoModule
    ],
    providers: [EstoqueService]
})
export class ProdutoListModule { }