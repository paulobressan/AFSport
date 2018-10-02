import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CategoriaListComponent } from './categoria-list/categoria-list.component';

const routes: Routes = [
    {
        path: '',
        component: CategoriaListComponent
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [RouterModule]
})
export class CategoriasRoutingModule { }