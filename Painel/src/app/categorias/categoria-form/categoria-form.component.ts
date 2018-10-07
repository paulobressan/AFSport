import { Component, OnInit, Input } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import swal from 'sweetalert';

import { CategoriaService } from "../categoria/categoria.service";
import { Categoria } from "../categoria/categoria";
import { Router, ActivatedRoute } from "@angular/router";
import { BaseFormComponent } from "../../core/base/base-form.component";
import { Produto } from "../../produtos/produto/produto";

@Component({
    templateUrl: './categoria-form.component.html'
})
export class CategoriaFormComponent implements BaseFormComponent<Produto>, OnInit {
    categoriaForm: FormGroup;
    @Input() categoria: Categoria;

    constructor(
        private formBuilder: FormBuilder,
        private categoriaService: CategoriaService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.categoria = this.activatedRoute.snapshot.data.categoria;
        this.categoriaForm = this.formBuilder.group({
            idCategoria: [this.categoria ? this.categoria.idCategoria : 0],
            nome: [this.categoria ? this.categoria.nome : '', [
                Validators.required,
                Validators.maxLength(50)
            ]],
            descricao: [this.categoria ? this.categoria.descricao : '', [
                Validators.maxLength(255)
            ]],
            isAtivo: [this.categoria ? this.categoria.isAtivo : true]
        })
    }

    salvar() {
        var categoria = this.categoriaForm.getRawValue() as Categoria;
        if (categoria.idCategoria)
            this.alterar(categoria);
        else
            this.inserir(categoria);
    }

    inserir(categoria: Categoria) {
        this.categoriaService.inserir(categoria)
            .subscribe(categoria => {
                swal("Enviada com sucesso!", "Categoria cadastrada com sucesso", "success");
                this.router.navigate(['/categoria']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(categoria: Categoria) {
        this.categoriaService.alterar(categoria.idCategoria, categoria)
            .subscribe(categoria => {
                swal("Enviada com sucesso!", "Categoria alterada com sucesso", "success");
                this.router.navigate(['/categoria']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}