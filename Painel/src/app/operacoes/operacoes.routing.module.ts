import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OperacaoListComponent } from './operacao-list/operacao-list.component';
import { OperacaoListResolve } from './operacao-list/operacao-list.resolve';

const routes: Routes = [
    {
        path: '',
        component: OperacaoListComponent,
        resolve: {
            operacoes: OperacaoListResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class OperacoesRoutingModule { }