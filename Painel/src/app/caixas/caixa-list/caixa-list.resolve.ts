import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Caixa } from '../caixa/caixa';
import { CaixaService } from '../caixa/caixa.service';

@Injectable()
export class CaixaListResolve implements Resolve<Observable<Caixa[]>> {
    constructor(private caixaService: CaixaService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Caixa[]> | any {
        return this.caixaService.listar();
    }
}
