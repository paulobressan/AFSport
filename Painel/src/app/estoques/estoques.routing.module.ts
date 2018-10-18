import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { EstoqueListResolve } from './estoque-list/estoque-list.resolve';
import { EstoqueListComponent } from './estoque-list/estoque-list.component';

const routes: Routes = [
    {
        path: '',
        component: EstoqueListComponent,
        resolve: {
            estoques: EstoqueListResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class EstoquesRoutingModule { }