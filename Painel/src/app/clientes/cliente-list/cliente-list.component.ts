import { Component, OnInit } from '@angular/core';

import { BaseListComponent } from '../../core/base/base-list.component';
import { Cliente } from '../cliente/cliente';
import { ClienteService } from '../cliente/cliente.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: './cliente-list.component.html'
})
export class ClienteListComponent implements BaseListComponent<Cliente>, OnInit {
    clientes: Cliente[];

    constructor(
        private clienteService: ClienteService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.clientes = this.activatedRouter.snapshot.data.clientes;
    }

    ativarInativar(isAtivo: boolean, cliente: Cliente) {
        this.clienteService.ativarInativar(cliente.idCliente, cliente)
            .subscribe(() => {
                this.listar();
                swal("Enviado com sucesso", `Cliente ${cliente.nome} foi ${isAtivo ? 'ativado' : 'inativado'} com sucesso!`, "success");
            });
    }

    remover(cliente: Cliente) {
        swal({
            title: "Atenção",
            text: `Confirma a remoção do Cliente ${cliente.nome}?`,
            icon: "warning",
            dangerMode: true,
        })
            .then(result => {
                if (result) {
                    this.clienteService.remover(cliente.idCliente)
                        .subscribe(() => {
                            this.listar();
                            swal("Enviado com sucesso", `Cliente ${cliente.nome} removido com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error.msg, "error");
                        });
                }
            });
    }

    listar() {
        this.clienteService.listar()
            .subscribe(Clientes => this.clientes = Clientes);
    }

    alterar(Cliente: Cliente) {
        this.router.navigate(['Cliente', 'alterar-cliente', Cliente.idCliente]);
    }
}