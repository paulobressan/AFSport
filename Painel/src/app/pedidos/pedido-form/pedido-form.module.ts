import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MensagemModule } from 'src/app/shared/components/mensagem/mensagem.module';
import { PedidoFormComponent } from './pedido-form.component';

@NgModule({
    declarations: [PedidoFormComponent],
    imports: [
        CommonModule,
        RouterModule,
        ReactiveFormsModule,
        MensagemModule
    ]
})
export class PedidoFormModule { }