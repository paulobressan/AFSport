import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';

import { CidadeListComponent } from './cidade-list/cidade-list.component';
import { CidadeListResolve } from './cidade-list/cidade-list.resolve';
import { CidadeFormComponent } from './cidade-form/cidade-form.component';
import { EstadoAtivosResolve } from '../estados/estado/estado-ativos.resolve';
import { CidadeFormResolve } from './cidade-form/cidade-form.resolve';

const routes: Routes = [
    {
        path: '',
        component: CidadeListComponent,
        resolve: {
            cidades: CidadeListResolve
        }
    },
    {
        path: 'nova-cidade',
        component: CidadeFormComponent,
        resolve: {
            estados: EstadoAtivosResolve
        }
    },
    {
        path: 'alterar-cidade/:id',
        component: CidadeFormComponent,
        resolve: {
            estados: EstadoAtivosResolve,
            cidade: CidadeFormResolve
        }
    }
]

@NgModule({
    declarations: [],
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class CidadesRoutingModule { }