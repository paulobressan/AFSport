import { Component, OnInit } from '@angular/core';

import { BaseListComponent } from '../../core/base/base-list.component';
import { Cliente } from '../cliente/cliente';

@Component({
    templateUrl: './cliente-list.component.html'
})
export class ClienteListComponent implements BaseListComponent<Cliente>, OnInit {
    
    constructor() { }

    ngOnInit(): void { }

    ativarInativar(isAtivo: boolean, obj: Cliente) {
        throw new Error("Method not implemented.");
    }
    remover(obj: Cliente) {
        throw new Error("Method not implemented.");
    }
    listar() {
        throw new Error("Method not implemented.");
    }
    alterar(obj: Cliente) {
        throw new Error("Method not implemented.");
    }
}
