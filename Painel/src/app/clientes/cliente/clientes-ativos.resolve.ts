import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Cliente } from './cliente';
import { ClienteService } from './cliente.service';

@Injectable()
export class ClientesAtivosResolve implements Resolve<Cliente[]> {
    constructor(private clienteService: ClienteService) { }
    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Cliente[]> {
        return this.clienteService.listarAtivos();
    }
}
