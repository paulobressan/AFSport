import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { Validators } from '@angular/forms';

import { Estado } from '../estado/estado';
import { EstadoService } from '../estado/estado.service';

@Component({
    templateUrl: './estado-form.component.html'
})
export class EstadoFormComponent implements OnInit {
    estadoForm: FormGroup;
    estado: Estado;

    constructor(
        private formBuilder: FormBuilder,
        private estadoService: EstadoService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.estado = this.activatedRoute.snapshot.data.estado;
        this.estadoForm = this.formBuilder.group({
            idEstado: [this.estado ? this.estado.idEstado : 0],
            nome: [this.estado ? this.estado.nome : '', [
                Validators.required,
                Validators.maxLength(50)
            ]],
            sigla: [this.estado ? this.estado.sigla : '', [
                Validators.maxLength(2)
            ]],
            isAtivo: [this.estado ? this.estado.isAtivo : true]
        })
    }

    salvar() {
        var estado: Estado = this.estadoForm.getRawValue() as Estado;
        if (estado.idEstado)
            this.alterar(estado);
        else
            this.inserir(estado);
    }

    inserir(estado: Estado) {
        this.estadoService.inserir(estado)
            .subscribe(estado => {
                swal("Enviada com sucesso!", "Estado cadastrado com sucesso", "success");
                this.router.navigate(['/estado']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(estado: Estado) {
        this.estadoService.alterar(estado.idEstado, estado)
            .subscribe(estado => {
                swal("Enviada com sucesso!", "Estado alterado com sucesso", "success");
                this.router.navigate(['/estado']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
