import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { PedidoListModule } from "./pedido-list/pedido-list.module";
import { PedidoService } from "./pedido/pedido.service";
import { PedidoListResolve } from "./pedido-list/pedido-list.revolve";
import { PedidosRoutingModule } from "./pedidos.routing";
import { PedidoFormResolve } from "./pedido-form/pedido-form.resolve";
import { ClientesAtivosResolve } from "../clientes/cliente/clientes-ativos.resolve";
import { PedidoFormModule } from "./pedido-form/pedido-form.module";
import { ClienteService } from "../clientes/cliente/cliente.service";
import { ProdutoService } from "../produtos/produto/produto.service";
import { OperacaoListResolve } from "../operacoes/operacao-list/operacao-list.resolve";
import { OperacaoService } from "../operacoes/operacao/operacao.service";
import { PedidoFinalizarModule } from "./pedido-finalizar/pedido-finalizar.module";

@NgModule({
    imports: [
        CommonModule,
        PedidosRoutingModule,
        PedidoListModule,
        PedidoFormModule,
        PedidoFinalizarModule
    ],
    providers: [
        PedidoService,
        ClienteService,
        ProdutoService,
        OperacaoService,
        PedidoListResolve,
        PedidoFormResolve,
        ClientesAtivosResolve,
        OperacaoListResolve
    ]
})
export class PedidosModule { }