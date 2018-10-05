import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CategoriaListComponent } from './categoria-list/categoria-list.component';
import { CategoriaResolver } from './categoria/categoria.resolve';
import { CategoriaFormComponent } from './categoria-form/categoria-form.component';

const routes: Routes = [
    {
        path: '',
        component: CategoriaListComponent,
        resolve:{
            categorias: CategoriaResolver
        }
    },
    {
        path: 'nova-categoria',
        component: CategoriaFormComponent
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)    
    ],
    exports: [RouterModule]
})
export class CategoriasRoutingModule { }