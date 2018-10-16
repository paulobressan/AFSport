import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { CidadeFormComponent } from './cidade-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { MensagemModule } from '../../shared/components/mensagem/mensagem.module';

@NgModule({
    declarations: [CidadeFormComponent],
    imports: [
        CommonModule,
        RouterModule,
        ReactiveFormsModule,
        MensagemModule
    ]
})
export class CidadeFormModule { }