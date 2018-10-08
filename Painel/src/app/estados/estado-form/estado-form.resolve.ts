import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Estado } from '../estado/estado';
import { EstadoService } from '../estado/estado.service';

@Injectable()
export class EstadoFormResolve implements Resolve<Observable<Estado>> {
    constructor(private estadoService: EstadoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        const id = route.params.id;
        if (id)
            return this.estadoService.listarPorId(id);
    }
}
