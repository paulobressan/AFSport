import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Pedido } from '../pedido/pedido';
import { PedidoService } from '../pedido/pedido.service';
import { PedidoStatus } from '../pedido/status.enum';

@Component({
    templateUrl: './pedido-list.component.html',
})
export class PedidoListComponent implements OnInit {
    pedidos: Pedido[];

    constructor(
        private pedidoService: PedidoService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.pedidos = this.activatedRouter.snapshot.data.pedidos;
    }

    listar() {
        this.pedidoService.listar()
            .subscribe(pedidos => this.pedidos = pedidos);
    }

    cancelar(pedido: Pedido): void {
        this.pedidoService.cancelarPedido(pedido.idPedido)
            .subscribe(() => {
                this.listar();
                swal("Enviado com sucesso", `Pedido ${pedido.idPedido} foi cancelado com sucesso!`, "success");
            }, err => swal("Problemas ao enviar", err.error.msg, "error"))
    }

    finalizar(pedido: Pedido): void {
        this.router.navigate(['pedido', pedido.idPedido, 'finalizar-pedido'])
    }

    getStatus(status: PedidoStatus): string {
        switch (status) {
            case PedidoStatus.Aberto:
                return "Aberto";
            case PedidoStatus.Cancelado:
                return "Cancelado";
            case PedidoStatus.Finalizado:
                return "Finalizado";
        }
    }

    isCancelado(pedido: Pedido): boolean {
        return pedido.status == PedidoStatus.Cancelado;
    }

    isFinalizado(pedido: Pedido): boolean {
        return pedido.status == PedidoStatus.Finalizado;
    }
}
