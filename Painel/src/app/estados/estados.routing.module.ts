import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { EstadoListComponent } from './estado-list/estado-list.component';
import { EstadoListResolve } from './estado-list/estado-list.resolve';

const routes: Routes = [
    {
        path: '',
        component: EstadoListComponent,
        resolve: {
            estados: EstadoListResolve
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