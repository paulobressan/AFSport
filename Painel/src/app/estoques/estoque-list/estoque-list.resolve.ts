import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Estoque } from '../estoque/estoque';
import { EstoqueService } from '../estoque/estoque.service';

@Injectable()
export class EstoqueListResolve implements Resolve<Observable<Estoque[]>> {
    constructor(private estoqueService: EstoqueService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Estoque[]> | any {
        return this.estoqueService.listar();
    }
}
