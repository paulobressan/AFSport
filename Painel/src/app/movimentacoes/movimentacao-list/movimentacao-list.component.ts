import { Component, OnInit } from '@angular/core';
import { BaseListComponent } from 'src/app/core/base/base-list.component';
import { Movimentacao } from '../movimentacao/movimentacao';
import { MovimentacaoService } from '../movimentacao/movimentacao.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: './movimentacao-list.component.html'
})
export class MovimentacaoListComponent implements OnInit {
    movimentacoes: Movimentacao[];

    constructor(
        private movimentacaoService: MovimentacaoService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.movimentacoes = this.activatedRouter.snapshot.data.movimentacoes;
    }

    listar() {
        this.movimentacaoService.listar()
            .subscribe(movimentacoes => this.movimentacoes = movimentacoes);
    }

    alterar(movimentacao: Movimentacao) {
        this.router.navigate(['movimentacao', 'alterar-movimentacao', movimentacao.idMovimentacao]);
    }
}
