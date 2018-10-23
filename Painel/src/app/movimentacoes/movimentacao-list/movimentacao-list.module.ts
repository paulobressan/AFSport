import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MovimentacaoListComponent } from './movimentacao-list.component';

@NgModule({
    declarations: [MovimentacaoListComponent],
    imports: [
        CommonModule,
        RouterModule
    ]
})
export class MovimentacaoListModule { }