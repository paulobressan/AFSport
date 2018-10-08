import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { EstadoFormComponent } from './estado-form.component';
import { MensagemModule } from '../../shared/components/mensagem/mensagem.module';

@NgModule({
    declarations: [EstadoFormComponent],
    imports: [
        CommonModule,
        ReactiveFormsModule,
        RouterModule,
        MensagemModule
    ]
})
export class EstadoFormModule { }