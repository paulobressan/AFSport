import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Pedido } from '../pedido/pedido';
import { PedidoService } from '../pedido/pedido.service';

@Injectable()
export class PedidoListResolve implements Resolve<Pedido[]> {
    constructor(private pedidoService: PedidoService) { }
    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Pedido[]> {
        return this.pedidoService.listar();
    }
}
