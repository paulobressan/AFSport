import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CategoriaListComponent } from './categoria-list/categoria-list.component';
import { CategoriaFormComponent } from './categoria-form/categoria-form.component';
import { CategoriaListResolver } from './categoria-list/categoria-lista.resolve';
import { CategoriaFormResolve } from './categoria-form/categoria-form.resolve';

const routes: Routes = [
    {
        path: '',
        component: CategoriaListComponent,
        resolve: {
            categorias: CategoriaListResolver
        }
    },
    {
        path: 'nova-categoria',
        component: CategoriaFormComponent
    },
    {
        path: 'alterar-categoria/:id',
        component: CategoriaFormComponent,
        resolve: {
            categoria: CategoriaFormResolve
        }
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [RouterModule]
})
export class CategoriasRoutingModule { }