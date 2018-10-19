import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { EstoqueListResolve } from './estoque-list/estoque-list.resolve';
import { EstoqueListComponent } from './estoque-list/estoque-list.component';
import { EstoqueFormComponent } from './estoque-form/estoque-form.component';
import { ProdutoSemEstoqueResolve } from '../produtos/produto/produto-sem-estoque.resolve';

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
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class EstoquesRoutingModule { }