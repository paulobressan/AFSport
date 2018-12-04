import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { PedidoListModule } from "./pedido-list/pedido-list.module";
import { PedidoService } from "./pedido/pedido.service";
import { PedidoListResolve } from "./pedido-list/pedido-list.revolve";
import { PedidosRoutingModule } from "./pedidos.routing";

@NgModule({
    imports: [
        CommonModule,
        PedidosRoutingModule,
        PedidoListModule
    ],
    providers: [
        PedidoService,
        PedidoListResolve
    ]
})
export class PedidosModule { }