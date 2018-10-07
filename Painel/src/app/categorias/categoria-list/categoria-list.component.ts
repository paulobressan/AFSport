import { Component, OnInit } from '@angular/core';
import swal from 'sweetalert';

import { Categoria } from '../categoria/categoria';
import { CategoriaService } from '../categoria/categoria.service';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseListComponent } from '../../core/base/base-list.component';

@Component({
    selector: 'af-categoria-list',
    templateUrl: './categoria-list.component.html'
})
export class CategoriaListComponent implements BaseListComponent<Categoria>, OnInit {
    categorias: Categoria[];

    constructor(
        private categoriaService: CategoriaService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.categorias = this.activatedRouter.snapshot.data.categorias;
    }

    ativarInativar(isAtivo: boolean, categoria: Categoria) {
        categoria.isAtivo = isAtivo;
        this.categoriaService.ativarInativar(categoria.idCategoria, categoria)
            .subscribe(() => {
                this.listar();
                swal("Enviado com sucesso", `Categoria ${categoria.nome} foi ${isAtivo ? 'ativada' : 'inativada'} com sucesso!`, "success");
            });
    }

    remover(categoria: Categoria) {
        swal({
            title: "Atenção",
            text: `Confirma a remoção da categoria ${categoria.nome}?`,
            icon: "warning",
            dangerMode: true,
        })
            .then(result => {
                if (result) {
                    this.categoriaService.remover(categoria.idCategoria)
                        .subscribe(() => {
                            this.listar();
                            swal("Enviado com sucesso", `Categoria ${categoria.nome} removida com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error.msg, "error");
                        });
                }
            });
    }

    listar() {
        this.categoriaService.listar()
            .subscribe(categorias => this.categorias = categorias);
    }

    alterar(categoria: Categoria) {
        this.router.navigate(['categoria', 'alterar-categoria', categoria.idCategoria]);
    }
}