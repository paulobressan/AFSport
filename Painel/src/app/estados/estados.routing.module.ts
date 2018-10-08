import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { EstadoListComponent } from './estado-list/estado-list.component';
import { EstadoListResolve } from './estado-list/estado-list.resolve';
import { EstadoFormComponent } from './estado-form/estado-form.component';
import { EstadoFormResolve } from './estado-form/estado-form.resolve';

const routes: Routes = [
    {
        path: '',
        component: EstadoListComponent,
        resolve: {
            estados: EstadoListResolve
        }
    },
    {
        path: 'novo-estado',
        component: EstadoFormComponent
    },
    {
        path: 'alterar-estado/:id',
        component: EstadoFormComponent,
        resolve: {
            estado: EstadoFormResolve
        }
    }
]

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [RouterModule]
})
export class EstadosRoutingModule { }