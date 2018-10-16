import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';

import { Cidade } from '../cidade/cidade';
import { CidadeService } from '../cidade/cidade.service';

@Injectable()
export class CidadeFormResolve implements Resolve<Observable<Cidade>> {
    constructor(
        private cidadeService: CidadeService
    ) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        let id = route.params.id;
        if (id)
            return this.cidadeService.listarPorId(id);
    }
}
