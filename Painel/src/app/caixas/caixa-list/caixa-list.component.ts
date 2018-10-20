import { Component, OnInit } from '@angular/core';
import { BaseListComponent } from 'src/app/core/base/base-list.component';
import { Caixa } from '../caixa/caixa';

@Component({
    templateUrl: './caixa-list.component.html'
})
export class CaixaListComponent implements BaseListComponent<Caixa>, OnInit {
    constructor() { }

    ngOnInit(): void { }

    ativarInativar(isAtivo: boolean, obj: Caixa) {
        throw new Error("Method not implemented.");
    }
    remover(obj: Caixa) {
        throw new Error("Method not implemented.");
    }
    listar() {
        throw new Error("Method not implemented.");
    }
    alterar(obj: Caixa) {
        throw new Error("Method not implemented.");
    }
}
