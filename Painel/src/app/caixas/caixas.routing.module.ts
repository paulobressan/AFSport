import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CaixaListComponent } from './caixa-list/caixa-list.component';
import { CaixaListResolve } from './caixa-list/caixa-list.resolve';
import { CaixaFormComponent } from './caixa-form/caixa-form.component';
import { CaixaFormResolve } from './caixa-form/caixa-form.resolve';

const routes: Routes = [
    {
        path: '',
        component: CaixaListComponent,
        resolve: {
            caixas: CaixaListResolve
        }
    },
    {
        path: 'novo-caixa',
        component: CaixaFormComponent
    },
    {
        path: 'alterar-caixa/:id',
        component: CaixaFormComponent,
        resolve: {
            caixa: CaixaFormResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class CaixasRoutingModule { }