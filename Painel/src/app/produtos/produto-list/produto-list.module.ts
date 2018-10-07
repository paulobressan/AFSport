import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { ProdutoListComponent } from './produto-list.component';
import { IsAtivoModule } from '../../shared/components/is-ativo/is-ativo.module';

@NgModule({
    declarations: [ProdutoListComponent],
    imports: [
        CommonModule,
        RouterModule,
        IsAtivoModule
    ]
})
export class ProdutoListModule { }