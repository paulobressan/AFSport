import { Component, OnInit } from '@angular/core';
import { BaseListComponent } from 'src/app/core/base/base-list.component';
import { Caixa } from '../caixa/caixa';
import { CaixaService } from '../caixa/caixa.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: './caixa-list.component.html'
})
export class CaixaListComponent implements OnInit {
    caixas: Caixa[];

    constructor(
        private caixaService: CaixaService,
        private activatedRouter: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.caixas = this.activatedRouter.snapshot.data.caixas;
    }

    listar() {
        this.caixaService.listar()
            .subscribe(caixas => this.caixas = caixas);
    }

    alterar(caixa: Caixa) {
        this.router.navigate(['caixa', 'alterar-caixa', caixa.idCaixa]);
    }
}
