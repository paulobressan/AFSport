import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Operacao } from '../operacao/operacao';
import { OperacaoService } from '../operacao/operacao.service';

@Injectable()
export class OperacaoFormResolve implements Resolve<Observable<Operacao>> {
    constructor(private operacaoService: OperacaoService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Operacao> | any {
        let id = route.params.id;
        if (id)
            return this.operacaoService.listarPorId(id);
    }
}
