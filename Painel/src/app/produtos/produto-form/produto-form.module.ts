import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';

import { ProdutoFormComponent } from './produto-form.component';
import { MensagemModule } from '../../shared/components/mensagem/mensagem.module';

@NgModule({
    declarations: [ProdutoFormComponent],
    imports: [
        CommonModule,
        RouterModule,
        ReactiveFormsModule,
        MensagemModule
    ],
    exports: []
})
export class ProdutoFormModule { }