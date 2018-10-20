import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { BaseFormComponent } from '../../core/base/base-form.component';
import { Produto } from '../produto/produto';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ProdutoService } from '../produto/produto.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Categoria } from '../../categorias/categoria/categoria';
import { ValidateIdValidator } from '../../shared/components/validators/validate-id.validator';

@Component({
    templateUrl: './produto-form.component.html'
})
export class ProdutoFormComponent implements BaseFormComponent<Produto>, OnInit {
    @ViewChild('nomeInput') nomeInput: ElementRef<HTMLInputElement>;
    produtoForm: FormGroup;
    produto: Produto;
    categorias: Categoria[];

    constructor(
        private formBuilder: FormBuilder,
        private produtoService: ProdutoService,
        private router: Router,
        private activatedRoute: ActivatedRoute
    ) { }

    ngOnInit(): void {
        this.categorias = this.activatedRoute.snapshot.data.categorias;
        this.produto = this.activatedRoute.snapshot.data.produto;
        this.produtoForm = this.formBuilder.group({
            idProduto: [this.produto ? this.produto.idProduto : 0],
            nome: [this.produto ? this.produto.nome : '', [
                Validators.required,
                Validators.maxLength(100)
            ]],
            descricao: [this.produto ? this.produto.descricao : '', [
                Validators.maxLength(255)
            ]],
            idCategoria: [this.produto ? this.produto.categoria.idCategoria : null, [
                Validators.required
            ]],
            valorCompra: [this.produto ? this.produto.valorCompra : 0, [
                Validators.required
            ]],
            valorVenda: [this.produto ? this.produto.valorVenda : 0, [
                Validators.required
            ]],
            isAtivo: [true],
        });
        this.nomeInput.nativeElement.focus();
    }

    salvar() {
        var produto = this.produtoForm.getRawValue() as Produto;
        if (produto.idProduto)
            this.alterar(produto);
        else
            this.inserir(produto);
    }

    inserir(produto: Produto) {
        this.produtoService.inserir(produto)
            .subscribe(produto => {
                swal("Enviada com sucesso!", "Produto cadastrado com sucesso", "success");
                this.router.navigate(['/produto']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(produto: Produto) {
        this.produtoService.alterar(produto.idProduto, produto)
            .subscribe(produto => {
                swal("Enviada com sucesso!", "Produto alterado com sucesso", "success");
                this.router.navigate(['/produto']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
