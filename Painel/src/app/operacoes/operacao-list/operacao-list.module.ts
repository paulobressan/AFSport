import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IsAtivoModule } from 'src/app/shared/components/is-ativo/is-ativo.module';
import { RouterModule } from '@angular/router';
import { OperacaoListComponent } from './operacao-list.component';

@NgModule({
    declarations: [OperacaoListComponent],
    imports: [
        CommonModule,
        IsAtivoModule,
        RouterModule
    ]
})
export class OperacaoListModule { }