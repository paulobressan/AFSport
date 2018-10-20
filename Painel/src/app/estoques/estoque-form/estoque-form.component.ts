import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

import { BaseFormComponent } from 'src/app/core/base/base-form.component';
import { Estoque } from '../estoque/estoque';
import { Produto } from 'src/app/produtos/produto/produto';
import { EstoqueService } from '../estoque/estoque.service';
import { ValidateIdValidator } from '../../shared/components/validators/validate-id.validator';

@Component({
    templateUrl: './estoque-form.component.html',
})
export class EstoqueFormComponent implements BaseFormComponent<Estoque>, OnInit {
    @ViewChild('quantidadeInput') quantidadeInput: ElementRef<HTMLInputElement>;
    estoqueForm: FormGroup;
    estoque: Estoque;
    produtos: Produto[];

    constructor(
        private formBuilder: FormBuilder,
        private estoqueService: EstoqueService,
        private router: Router,
        private activatedRoute: ActivatedRoute
    ) { }

    ngOnInit(): void {
        this.produtos = this.activatedRoute.snapshot.data.produtos;
        this.estoque = this.activatedRoute.snapshot.data.estoque;
        this.estoqueForm = this.formBuilder.group({
            idEstoque: [this.estoque ? this.estoque.idEstoque : 0],
            quantidade: [this.estoque ? this.estoque.quantidade : 0, [
                Validators.required
            ]],
            idProduto: [this.estoque && this.estoque.produto ? this.estoque.produto.idProduto : null, [
                Validators.required
            ]],
            isAtivo: [true],
        });
        this.quantidadeInput.nativeElement.focus();
    }

    salvar() {
        var estoque = this.estoqueForm.getRawValue() as Estoque;
        if (estoque.idEstoque)
            this.alterar(estoque);
        else
            this.inserir(estoque);
    }

    inserir(estoque: Estoque) {
        this.estoqueService.inserir(estoque)
            .subscribe(estoque => {
                swal("Enviada com sucesso!", "Estoque cadastrado com sucesso", "success");
                this.router.navigate(['/estoque']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(estoque: Estoque) {
        this.estoqueService.alterar(estoque.idEstoque, estoque)
            .subscribe(estoque => {
                swal("Enviada com sucesso!", "Estoque alterado com sucesso", "success");
                this.router.navigate(['/estoque']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    isAlterar() {
        var teste = this.activatedRoute.snapshot.params.id || false;
        return teste;
    }
}
