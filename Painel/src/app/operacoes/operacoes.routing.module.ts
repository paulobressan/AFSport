import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { OperacaoListComponent } from './operacao-list/operacao-list.component';
import { OperacaoListResolve } from './operacao-list/operacao-list.resolve';
import { OperacaoFormComponent } from './operacao-form/operacao-form.component';
import { OperacaoFormResolve } from './operacao-form/operacao-form.resolve';

const routes: Routes = [
    {
        path: '',
        component: OperacaoListComponent,
        resolve: {
            operacoes: OperacaoListResolve
        }
    },
    {
        path: 'nova-operacao',
        component: OperacaoFormComponent
    },
    {
        path: 'alterar-operacao/:id',
        component: OperacaoFormComponent,
        resolve: {
            operacao: OperacaoFormResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class OperacoesRoutingModule { }