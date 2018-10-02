import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriaListModule } from './categoria-list/categoria-list.module';
import { CategoriaService } from './categoria/categoria.service';
import { CategoriasRoutingModule } from './categorias.routing.module';

@NgModule({
    imports: [
        CommonModule,
        CategoriaListModule,
        CategoriasRoutingModule
    ],
    providers: [CategoriaService]
})
export class CategoriasModule { }