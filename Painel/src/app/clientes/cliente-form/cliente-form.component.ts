import { Component, OnInit } from '@angular/core';
import { BaseFormComponent } from '../../core/base/base-form.component';
import { Cliente } from '../cliente/cliente';

@Component({
    templateUrl: './cliente-form.component.html'
})
export class ClienteFormComponent implements BaseFormComponent<Cliente>, OnInit {
    constructor() { }

    ngOnInit(): void { }

    salvar() {
        throw new Error("Method not implemented.");
    }
    inserir(obj: Cliente) {
        throw new Error("Method not implemented.");
    }
    alterar(obj: Cliente) {
        throw new Error("Method not implemented.");
    }
}
