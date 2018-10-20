import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { CaixaListComponent } from './caixa-list/caixa-list.component';
import { CaixaListResolve } from './caixa-list/caixa-list.resolve';

const routes: Routes = [
    {
        path: '',
        component: CaixaListComponent,
        resolve: {
            caixas: CaixaListResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class CaixasRoutingModule { }