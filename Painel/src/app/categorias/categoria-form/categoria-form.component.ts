import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

import { CategoriaService } from "../categoria/categoria.service";
import { Categoria } from "../categoria/categoria";

@Component({
    templateUrl: './categoria-form.component.html'
})
export class CategoriaFormComponent implements OnInit {
    categoriaForm: FormGroup;

    constructor(
        private formBuilder: FormBuilder,
        private categoriaService: CategoriaService
    ) { }

    ngOnInit(): void {
        this.categoriaForm = this.formBuilder.group({
            nome: ['', [
                Validators.required,
                Validators.maxLength(50)
            ]],
            descricao: ['', [
                Validators.maxLength(255)
            ]],
            isAtivo: [true]
        })
    }

    inserir(){
        var categoria = this.categoriaForm.getRawValue() as Categoria;
        this.categoriaService.inserir(categoria)
        .subscribe(categoria => {
            alert("Categoria enviada com sucesso")
        });
    }
}