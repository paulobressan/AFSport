import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { EstoqueListResolve } from './estoque-list/estoque-list.resolve';
import { EstoqueListComponent } from './estoque-list/estoque-list.component';
import { EstoqueFormComponent } from './estoque-form/estoque-form.component';
import { ProdutoSemEstoqueResolve } from '../produtos/produto/produto-sem-estoque.resolve';
import { EstoqueFormResolve } from './estoque-form/estoque-form.resolve';
import { ProdutoComEstoqueResolve } from '../produtos/produto/produto-com-estoque.resolve';

const routes: Routes = [
    {
        path: '',
        component: EstoqueListComponent,
        resolve: {
            estoques: EstoqueListResolve
        }
    },
    {
        path: 'novo-estoque',
        component: EstoqueFormComponent,
        resolve: {
            produtos: ProdutoSemEstoqueResolve
        }
    },
    {
        path: 'alterar-estoque/:id',
        component: EstoqueFormComponent,
        resolve: {
            produtos: ProdutoComEstoqueResolve,
            estoque: EstoqueFormResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class EstoquesRoutingModule { }