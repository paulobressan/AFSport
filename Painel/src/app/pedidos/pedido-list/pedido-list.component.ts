import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Pedido } from '../pedido/pedido';
import { PedidoService } from '../pedido/pedido.service';

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

    alterar(pedido: Pedido) {
        this.router.navigate(['pedido', 'alterar-pedido', pedido.idPedido]);
    }
}
