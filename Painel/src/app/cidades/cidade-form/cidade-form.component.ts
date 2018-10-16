import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import swal from 'sweetalert';

import { Cidade } from '../cidade/cidade';
import { BaseFormComponent } from '../../core/base/base-form.component';
import { CidadeService } from '../cidade/cidade.service';
import { Estado } from '../../estados/estado/estado';

@Component({
    templateUrl: './cidade-form.component.html'
})
export class CidadeFormComponent implements BaseFormComponent<Cidade>, OnInit {
    cidadeForm: FormGroup;
    cidade: Cidade;
    estados: Estado[];

    constructor(
        private formBuilder: FormBuilder,
        private CidadeService: CidadeService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.estados = this.activatedRoute.snapshot.data.estados;
        this.cidade = this.activatedRoute.snapshot.data.cidade;
        this.cidadeForm = this.formBuilder.group({
            idCidade: [this.cidade ? this.cidade.idCidade : 0],
            nome: [this.cidade ? this.cidade.nome : '', [
                Validators.required,
                Validators.maxLength(50)
            ]],
            idEstado: [this.cidade ? this.cidade.estado.idEstado : 1, 
                Validators.required
            ],
            isAtivo: [this.cidade ? this.cidade.isAtivo : true]
        })
    }

    salvar() {
        var Cidade: Cidade = this.cidadeForm.getRawValue() as Cidade;
        if (Cidade.idCidade)
            this.alterar(Cidade);
        else
            this.inserir(Cidade);
    }

    inserir(Cidade: Cidade) {
        this.CidadeService.inserir(Cidade)
            .subscribe(Cidade => {
                swal("Enviada com sucesso!", "Cidade cadastrada com sucesso", "success");
                this.router.navigate(['/cidade']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(Cidade: Cidade) {
        this.CidadeService.alterar(Cidade.idCidade, Cidade)
            .subscribe(Cidade => {
                swal("Enviada com sucesso!", "Cidade alterada com sucesso", "success");
                this.router.navigate(['/cidade']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
