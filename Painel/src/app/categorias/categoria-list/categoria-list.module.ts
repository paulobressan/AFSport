import { NgModule, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriaListComponent } from './categoria-list.component';
import { CategoriaService } from '../categoria/categoria.service';
import { Categoria } from '../categoria/categoria';

@NgModule({
    declarations: [CategoriaListComponent],
    imports: [
        CommonModule
    ],
    exports: [CategoriaListComponent],
    providers: [CategoriaService]
})
export class CategoriaListModule {
    categorias: Categoria = { idCategoria: 0, descricao: 'teste', nome: 'teste', isAtivo: true };
}