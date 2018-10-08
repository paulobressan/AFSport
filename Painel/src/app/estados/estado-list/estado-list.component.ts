import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import swal from 'sweetalert';

import { Estado } from '../estado/estado';
import { BaseListComponent } from '../../core/base/base-list.component';
import { EstadoService } from '../estado/estado.service';

@Component({
    templateUrl: './estado-list.component.html'
})
export class EstadoListComponent implements BaseListComponent<Estado>, OnInit {
    estados: Estado[];

    constructor(
        private estadoService: EstadoService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.estados = this.activatedRouter.snapshot.data.estados;
    }

    ativarInativar(isAtivo: boolean, estado: Estado) {
        estado.isAtivo = isAtivo;
        this.estadoService.ativarInativar(estado.idEstado, estado)
            .subscribe(() => {
                this.listar();
                swal("Enviado com sucesso", `Estado ${estado.nome} foi ${isAtivo ? 'ativado' : 'inativado'} com sucesso!`, "success");
            });
    }

    remover(estado: Estado) {
        swal({
            title: "Atenção",
            text: `Confirma a remoção da estado ${estado.nome}?`,
            icon: "warning",
            dangerMode: true,
        })
            .then(result => {
                if (result) {
                    this.estadoService.remover(estado.idEstado)
                        .subscribe(() => {
                            this.listar();
                            swal("Enviado com sucesso", `estado ${estado.nome} removido com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error.msg, "error");
                        });
                }
            });
    }

    listar() {
        this.estadoService.listar()
            .subscribe(estados => this.estados = estados);
    }

    alterar(estado: Estado) {
        this.router.navigate(['estado', 'alterar-estado', estado.idEstado]);
    }
}
