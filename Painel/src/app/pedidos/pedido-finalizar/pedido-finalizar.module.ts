import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { PedidoFinalizarComponent } from './pedido-finalizar.component';

@NgModule({
    declarations: [PedidoFinalizarComponent],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        ReactiveFormsModule
    ]
})
export class PedidoFinalizarModule { }