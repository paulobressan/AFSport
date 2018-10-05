import { NgModule, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriaListComponent } from './categoria-list.component';
import { CategoriaService } from '../categoria/categoria.service';

@NgModule({
    declarations: [CategoriaListComponent],
    imports: [
        CommonModule
    ],
    providers: [CategoriaService]
})
export class CategoriaListModule {
}