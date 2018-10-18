import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { Estado } from './estado';
import { EstadoService } from './estado.service';

@Injectable()
export class EstadoAtivosResolve implements Resolve<Observable<Estado>> {
    constructor(private estadoService: EstadoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Estado> |any {
        return this.estadoService.listarAtivos();
    }
}
