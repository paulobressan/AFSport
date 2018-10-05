import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriaListModule } from './categoria-list/categoria-list.module';
import { CategoriaService } from './categoria/categoria.service';
import { CategoriasRoutingModule } from './categorias.routing.module';
import { CategoriaResolver } from './categoria/categoria.resolve';
import { CategoriaFormModule } from './categoria-form/categoria-form.module';

@NgModule({
    imports: [
        CommonModule,
        CategoriaListModule,
        CategoriaFormModule,
        CategoriasRoutingModule
    ],
    providers: [
        CategoriaService,
        CategoriaResolver
    ]
})
export class CategoriasModule { }