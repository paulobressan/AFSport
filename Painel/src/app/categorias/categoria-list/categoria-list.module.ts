import { NgModule, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CategoriaListComponent } from './categoria-list.component';
import { CategoriaService } from '../categoria/categoria.service';
import { IsAtivoModule } from '../../shared/components/is-ativo/is-ativo.module';
import { RouterModule } from '@angular/router';

@NgModule({
    declarations: [CategoriaListComponent],
    imports: [
        CommonModule,
        IsAtivoModule,
        RouterModule
    ],
    providers: [CategoriaService]
})
export class CategoriaListModule {
}