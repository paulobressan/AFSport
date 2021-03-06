import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Cliente } from '../cliente/cliente';
import { ClienteService } from '../cliente/cliente.service';

@Injectable()
export class ClienteFormResolve implements Resolve<Observable<Cliente>> {
    constructor(private clienteService: ClienteService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Cliente> | any {
        let id = route.params.id;
        if (id)
            return this.clienteService.listarPorId(id);
    }
}
