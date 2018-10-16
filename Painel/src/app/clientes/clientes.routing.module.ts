import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ClienteListComponent } from './cliente-list/cliente-list.component';
import { ClienteListResolve } from './cliente-list/cliente-list.resolve';
import { ClienteFormComponent } from './cliente-form/cliente-form.component';
import { CidadeAtivasResolve } from '../cidades/cidade/cidade-ativas.resolve';

const routes: Routes = [
    {
        path: '',
        component: ClienteListComponent,
        resolve: {
            clientes: ClienteListResolve
        }
    },
    {
        path: 'novo-cliente',
        component: ClienteFormComponent,
        resolve: {
            cidades: CidadeAtivasResolve
        }
    }
]

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [RouterModule]
})
export class ClientesRoutingModule { }