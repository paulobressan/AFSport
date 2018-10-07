import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Produto } from '../produto/produto';
import { ProdutoService } from '../produto/produto.service';

@Injectable()
export class ProdutoListResolve implements Resolve<Observable<Produto[]>> {
    constructor(private produtoService: ProdutoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        return this.produtoService.listar();
    }
}
