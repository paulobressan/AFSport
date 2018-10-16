import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { Cidade } from '../cidade/cidade';
import { CidadeService } from '../cidade/cidade.service';

@Injectable()
export class CidadeListResolve implements Resolve<Observable<Cidade>> {
    constructor(private cidadeService: CidadeService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        return this.cidadeService.listar();
    }
}
