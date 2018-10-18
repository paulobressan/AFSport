import { Component, OnInit } from '@angular/core';
import { Estoque } from '../estoque/estoque';
import { Router, ActivatedRoute } from '@angular/router';
import swal from 'sweetalert';

import { EstoqueService } from '../estoque/estoque.service';
import { BaseListComponent } from 'src/app/core/base/base-list.component';

@Component({
    templateUrl: './estoque-list.component.html'
})
export class EstoqueListComponent implements BaseListComponent<Estoque>, OnInit {
    estoques: Estoque[];

    constructor(
        private estoqueService: EstoqueService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.estoques = this.activatedRoute.snapshot.data.estoques;
     }

    ativarInativar(isAtivo: boolean, estoque: Estoque) {
        // estoque.isAtivo = isAtivo;
        // estoque.idCategoria = estoque.categoria.idCategoria;
        // this.estoqueService.ativarInativar(estoque.idestoque, estoque)
        //     .subscribe(() => {
        //         this.listar();
        //         swal("Enviado com sucesso", `estoque ${estoque.nome} foi ${isAtivo ? 'ativada' : 'inativada'} com sucesso!`, "success");
        //     });
    }

    remover(estoque: Estoque) {
        swal({
            title: "Atenção",
            text: `Confirma a remoção do estoque do produto ${estoque.produto.nome}?`,
            icon: "warning",
            dangerMode: true,
        })
            .then(result => {
                if (result) {
                    this.estoqueService.remover(estoque.idEstoque)
                        .subscribe(() => {
                            this.listar();
                            swal("Enviado com sucesso", `Estoque do produto ${estoque.produto.nome} removido com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error.msg, "error");
                        });
                }
            });
    }

    listar() {
        this.estoqueService.listar()
            .subscribe(estoques => this.estoques = estoques);
    }

    alterar(estoque: Estoque) {
        this.router.navigate(['estoque', 'alterar-estoque', estoque.idEstoque]);
    }
}
