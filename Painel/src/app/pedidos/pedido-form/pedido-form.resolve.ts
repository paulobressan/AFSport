import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Pedido } from '../pedido/pedido';
import { PedidoService } from '../pedido/pedido.service';

@Injectable()
export class PedidoFormResolve implements Resolve<Pedido> {
    constructor(private pedidoService: PedidoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Pedido> {
        const id = route.params.id;
        if (id)
            return this.pedidoService.listarPorId(id);
    }
}
