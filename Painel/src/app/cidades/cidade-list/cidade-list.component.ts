import { Component, OnInit } from '@angular/core';
import { BaseListComponent } from '../../core/base/base-list.component';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import swal from 'sweetalert';

import { Cidade } from '../cidade/cidade';
import { CidadeService } from '../cidade/cidade.service';

@Component({
    templateUrl: './cidade-list.component.html'
})
export class CidadeListComponent implements BaseListComponent<Cidade>, OnInit {
    cidades: Cidade[];

    constructor(
        private cidadeService: CidadeService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.cidades = this.activatedRouter.snapshot.data.cidades;
    }

    ativarInativar(isAtivo: boolean, cidade: Cidade) {
        cidade.isAtivo = isAtivo;
        this.cidadeService.ativarInativar(cidade.idCidade, cidade)
            .subscribe(() => {
                this.listar();
                swal("Enviado com sucesso", `Cidade ${cidade.nome} foi ${isAtivo ? 'ativado' : 'inativado'} com sucesso!`, "success");
            });
    }

    remover(cidade: Cidade) {
        swal({
            title: "Atenção",
            text: `Confirma a remoção da Cidade ${cidade.nome}?`,
            icon: "warning",
            dangerMode: true,
        })
            .then(result => {
                if (result) {
                    this.cidadeService.remover(cidade.idCidade)
                        .subscribe(() => {
                            this.listar();
                            swal("Enviado com sucesso", `Cidade ${cidade.nome} removido com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error.msg, "error");
                        });
                }
            });
    }

    listar() {
        this.cidadeService.listar()
            .subscribe(cidades => this.cidades = cidades);
    }

    alterar(cidade: Cidade) {
        this.router.navigate(['cidade', 'alterar-cidade', cidade.idCidade]);
    }
}