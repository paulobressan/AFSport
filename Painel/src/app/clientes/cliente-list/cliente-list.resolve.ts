import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { Cliente } from '../cliente/cliente';
import { ClienteService } from '../cliente/cliente.service';

@Injectable()
export class ClienteListResolve implements Resolve<Observable<Cliente>> {
    constructor(private clienteService: ClienteService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        return this.clienteService.listar();
    }
}
