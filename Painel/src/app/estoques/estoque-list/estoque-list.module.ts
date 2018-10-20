import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EstoqueListComponent } from './estoque-list.component';
import { RouterModule } from '@angular/router';
import { IsAtivoModule } from 'src/app/shared/components/is-ativo/is-ativo.module';

@NgModule({
    declarations: [EstoqueListComponent],
    imports: [
        CommonModule,
        RouterModule
    ]
})
export class EstoqueListModule { }