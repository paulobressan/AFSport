import { Component, OnInit } from '@angular/core';
import swal from 'sweetalert';

import { Categoria } from '../categoria/categoria';
import { CategoriaService } from '../categoria/categoria.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'af-categoria-list',
    templateUrl: './categoria-list.component.html'
})
export class CategoriaListComponent implements OnInit {
    categorias: Categoria[];

    constructor(
        private categoriaService: CategoriaService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.categorias = this.activatedRouter.snapshot.data.categorias;
    }

    AtivarInativar(isAtivo: boolean, categoria: Categoria) {
        this.router.navigate(['categoria', 'alterar-categoria', categoria.idCategoria]);
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
                            this.selecionarCategorias();
                            swal("Enviado com sucesso", `Categoria ${categoria.nome} removida com sucesso!`, "success");
                        }, err => {
                            swal("Problemas ao enviar", err.error, "success");
                        });
                }
            });
    }

    selecionarCategorias() {
        this.categoriaService.listarCategorias()
            .subscribe(categorias => this.categorias = categorias);
    }

    alterar(categoria: Categoria) {
        this.router.navigate(['categoria', 'alterar-categoria', categoria.idCategoria]);
    }
}