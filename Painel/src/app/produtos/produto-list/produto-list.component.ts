import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import swal from 'sweetalert';

import { Produto } from '../produto/produto';
import { ProdutoService } from '../produto/produto.service';
import { BaseListComponent } from '../../core/base/base-list.component';

@Component({
    templateUrl: './produto-list.component.html',
    styleUrls: ['./produto-list.component.css']
})
export class ProdutoListComponent implements BaseListComponent<Produto>, OnInit {
    produtos: Produto[];
    produtosSemEstoque: Produto[];
    idProduto: number;

    constructor(
        private produtoService: ProdutoService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.produtos = this.activatedRoute.snapshot.data.produtos;
        this.produtosSemEstoque = this.activatedRoute.snapshot.data.produtosSemEstoque;
    }

    ativarInativar(isAtivo: boolean, produto: Produto) {
        produto.isAtivo = isAtivo;
        produto.idCategoria = produto.categoria.idCategoria;
        this.produtoService.ativarInativar(produto.idProduto, produto)
            .subscribe(() => {
                this.listar();
                swal("Enviado com sucesso", `Produto ${produto.nome} foi ${isAtivo ? 'ativada' : 'inativada'} com sucesso!`, "success");
            });
    }

    remover(produto: Produto) {
        swal({
            title: "Atenção",
            text: `Confirma a remoção da produto ${produto.nome}?`,
            icon: "warning",
            dangerMode: true,
        })
            .then(result => {
                if (result) {
                    this.produtoService.remover(produto.idProduto)
                        .subscribe(() => {
                            this.listar();
                            swal("Enviado com sucesso", `Produto ${produto.nome} removida com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error.msg, "error");
                        });
                }
            });
    }

    listar() {
        this.produtoService.listar()
            .subscribe(produtos => this.produtos = produtos);
    }

    alterar(produto: Produto) {
        this.router.navigate(['produto', 'alterar-produto', produto.idProduto]);
    }
}
