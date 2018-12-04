import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PedidoListComponent } from './pedido-list.component';

@NgModule({
    declarations: [PedidoListComponent],
    imports: [
        CommonModule,
        RouterModule
    ]
})
export class PedidoListModule { }