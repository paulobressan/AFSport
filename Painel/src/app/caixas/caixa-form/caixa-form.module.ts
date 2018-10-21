import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CaixaFormComponent } from './caixa-form.component';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MensagemModule } from 'src/app/shared/components/mensagem/mensagem.module';

@NgModule({
    declarations: [CaixaFormComponent],
    imports: [
        CommonModule,
        RouterModule,
        ReactiveFormsModule,
        MensagemModule
    ]
})
export class CaixaFormModule { }