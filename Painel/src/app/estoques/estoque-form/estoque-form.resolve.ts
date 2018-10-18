import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Estoque } from '../estoque/estoque';
import { EstoqueService } from '../estoque/estoque.service';

@Injectable()
export class EstoqueFormResolve implements Resolve<Observable<Estoque>> {
    constructor(private estoqueService: EstoqueService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Estoque> | any {
        let id = route.params.id;
        if (id)
            return this.estoqueService.listarPorId(id);
    }
}
