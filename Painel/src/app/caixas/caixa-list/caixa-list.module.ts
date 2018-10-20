import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CaixaListComponent } from './caixa-list.component';
import { RouterModule } from '@angular/router';

@NgModule({
    declarations: [CaixaListComponent],
    imports: [
        CommonModule,
        RouterModule
    ]
})
export class CaixaListModule { }