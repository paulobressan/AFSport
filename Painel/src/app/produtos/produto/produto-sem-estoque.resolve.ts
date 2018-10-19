import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

import { Produto } from './produto';
import { ProdutoService } from './produto.service';

@Injectable()
export class ProdutoSemEstoqueResolve implements Resolve<Observable<Produto[]>> {
    constructor(private produtoService: ProdutoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Produto[]> | any {
        return this.produtoService.listarProdutoSemEstoque();
    }
}
