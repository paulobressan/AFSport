import { Component, OnInit } from '@angular/core';
import { BaseListComponent } from 'src/app/core/base/base-list.component';
import { Operacao } from '../operacao/operacao';
import { Router, ActivatedRoute } from '@angular/router';
import { OperacaoService } from '../operacao/operacao.service';

@Component({
    templateUrl: './operacao-list.component.html'
})
export class OperacaoListComponent implements BaseListComponent<Operacao>, OnInit {
    operacoes: Operacao[];

    constructor(
        private operacaoService: OperacaoService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.operacoes = this.activatedRouter.snapshot.data.operacaos;
    }

    ativarInativar(isAtivo: boolean, operacao: Operacao) {
        operacao.isAtivo = isAtivo;
        this.operacaoService.ativarInativar(operacao.idOperacao, operacao)
            .subscribe(() => {
                this.listar();
                swal("Enviado com sucesso", `Operação ${operacao.nome} foi ${isAtivo ? 'ativada' : 'inativada'} com sucesso!`, "success");
            });
    }

    remover(operacao: Operacao) {
        swal({
            title: "Atenção",
            text: `Confirma a remoção da Operação ${operacao.nome}?`,
            icon: "warning",
            dangerMode: true,
        })
            .then(result => {
                if (result) {
                    this.operacaoService.remover(operacao.idOperacao)
                        .subscribe(() => {
                            this.listar();
                            swal("Enviado com sucesso", `Operação ${operacao.nome} removida com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error.msg, "error");
                        });
                }
            });
    }

    listar() {
        this.operacaoService.listar()
            .subscribe(operacaos => this.operacoes = operacaos);
    }

    alterar(operacao: Operacao) {
        this.router.navigate(['operacao', 'alterar-operacao', operacao.idOperacao]);
    }
}
