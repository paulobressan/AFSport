import { Component, OnInit } from '@angular/core';
import { BaseListComponent } from '../../core/base/base-list.component';
import { Estado } from '../estado/estado';

@Component({
    templateUrl: './estado-list.component.html',
    styleUrls: ['./estado-list.component.scss']
})
export class EstadoListComponent implements BaseListComponent<Estado>, OnInit {
    
    constructor() { }

    ngOnInit(): void { }

    ativarInativar(isAtivo: boolean, obj: Estado) {
        throw new Error("Method not implemented.");
    }
    remover(obj: Estado) {
        throw new Error("Method not implemented.");
    }
    listar() {
        throw new Error("Method not implemented.");
    }
    alterar(obj: Estado) {
        throw new Error("Method not implemented.");
    }
}
