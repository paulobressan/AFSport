import { Component, OnInit } from '@angular/core';

import { Categoria } from '../categoria/categoria';
import { CategoriaService } from '../categoria/categoria.service';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'af-categoria-list',
    templateUrl: './categoria-list.component.html'
})
export class CategoriaListComponent implements OnInit {
    categorias: Categoria[];

    constructor(
        private categoriaService: CategoriaService,
        private activatedRouter: ActivatedRoute
        ) { }

    ngOnInit(): void {
       this.categorias = this.activatedRouter.snapshot.data.categorias;
    }
}