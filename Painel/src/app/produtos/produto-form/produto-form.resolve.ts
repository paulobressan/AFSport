import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { Produto } from '../produto/produto';
import { ProdutoService } from '../produto/produto.service';

@Injectable()
export class ProdutoFormResolve implements Resolve<Observable<Produto>> {
    constructor(private produtoService: ProdutoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        const id = route.params.id;
        if (id)
            return this.produtoService.listarPorId(id);
    }
}
