import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MovimentacaoListComponent } from './movimentacao-list/movimentacao-list.component';
import { MovimentacaoListResolve } from './movimentacao-list/movimentacao-list.resolve';

const routes: Routes = [
    {
        path: '',
        component: MovimentacaoListComponent,
        resolve: {
            movimentacoes: MovimentacaoListResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class MovimentacoesRoutingModule { }