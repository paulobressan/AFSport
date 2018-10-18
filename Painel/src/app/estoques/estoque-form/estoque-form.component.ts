import { Component, OnInit } from '@angular/core';
import { BaseFormComponent } from 'src/app/core/base/base-form.component';
import { Estoque } from '../estoque/estoque';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Produto } from 'src/app/produtos/produto/produto';
import { EstoqueService } from '../estoque/estoque.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    templateUrl: './estoque-form.component.html',
})
export class EstoqueFormComponent implements BaseFormComponent<Estoque>, OnInit {
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
        // this.categorias = this.activatedRoute.snapshot.data.categorias;
        this.estoque = this.activatedRoute.snapshot.data.estoque;
        // this.estoqueForm = this.formBuilder.group({
        //     idestoque: [this.estoque ? this.estoque.idEstoque : 0],
        //     nome: [this.estoque ? this.estoque.nome : '', [
        //         Validators.required,
        //         Validators.maxLength(100)
        //     ]],
        //     descricao: [this.estoque ? this.estoque.descricao : '', [
        //         Validators.maxLength(255)
        //     ]],
        //     idCategoria: [this.estoque ? this.estoque.categoria.idCategoria : 1, [
        //         Validators.required
        //     ]],
        //     valorCompra: [this.estoque ? this.estoque.valorCompra : 0, [
        //         Validators.required
        //     ]],
        //     valorVenda: [this.estoque ? this.estoque.valorVenda : 0, [
        //         Validators.required
        //     ]],
        //     isAtivo: [true],
        // });
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
                swal("Enviada com sucesso!", "estoque cadastrado com sucesso", "success");
                this.router.navigate(['/estoque']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(estoque: Estoque) {
        this.estoqueService.alterar(estoque.idEstoque, estoque)
            .subscribe(estoque => {
                swal("Enviada com sucesso!", "estoque alterado com sucesso", "success");
                this.router.navigate(['/estoque']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
