import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Movimentacao } from '../movimentacao/movimentacao';
import { MovimentacaoService } from '../movimentacao/movimentacao.service';

@Injectable()
export class MovimentacaoListResolve implements Resolve<Observable<Movimentacao[]>> {
    constructor(private movimentacaoService: MovimentacaoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Movimentacao[]> | any {
        return this.movimentacaoService.listar();
    }
}
