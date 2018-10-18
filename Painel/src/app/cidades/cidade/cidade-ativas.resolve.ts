import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { Cidade } from './cidade';
import { CidadeService } from './cidade.service';

@Injectable()
export class CidadeAtivasResolve implements Resolve<Observable<Cidade[]>> {
    constructor(private cidadeService: CidadeService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Cidade[]> | any {
        return this.cidadeService.listarAtivas();
    }
}
