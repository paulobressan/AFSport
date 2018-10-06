import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriaListModule } from './categoria-list/categoria-list.module';
import { CategoriaService } from './categoria/categoria.service';
import { CategoriasRoutingModule } from './categorias.routing.module';
import { CategoriaFormModule } from './categoria-form/categoria-form.module';
import { CategoriaListResolver } from './categoria-list/categoria-lista.resolve';
import { CategoriaFormResolve } from './categoria-form/categoria-form.resolve';

@NgModule({
    imports: [
        CommonModule,
        CategoriaListModule,
        CategoriaFormModule,
        CategoriasRoutingModule
    ],
    providers: [
        CategoriaService,
        CategoriaListResolver,
        CategoriaFormResolve
    ]
})
export class CategoriasModule { }