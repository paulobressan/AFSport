import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { BaseFormComponent } from 'src/app/core/base/base-form.component';
import { Caixa } from '../caixa/caixa';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { CaixaService } from '../caixa/caixa.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: './caixa-form.component.html',
})
export class CaixaFormComponent implements BaseFormComponent<Caixa>, OnInit {
    @ViewChild('valorInput') valorInput: ElementRef<HTMLInputElement>;
    caixaForm: FormGroup;
    caixa: Caixa;

    constructor(
        private formBuilder: FormBuilder,
        private caixaService: CaixaService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.caixa = this.activatedRoute.snapshot.data.caixa;
        this.caixaForm = this.formBuilder.group({
            idcaixa: [this.caixa ? this.caixa.idCaixa : 0],
            nome: [this.caixa ? this.caixa.valorInicial : 0, [
                Validators.required
            ]]
        });
        this.valorInput.nativeElement.focus();
    }

    salvar() {
        var caixa: Caixa = this.caixaForm.getRawValue() as Caixa;
        if (caixa.idCaixa)
            this.alterar(caixa);
        else
            this.inserir(caixa);
    }

    inserir(caixa: Caixa) {
        this.caixaService.inserir(caixa)
            .subscribe(caixa => {
                swal("Enviada com sucesso!", "caixa cadastrado com sucesso", "success");
                this.router.navigate(['/caixa']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(caixa: Caixa) {
        this.caixaService.alterar(caixa.idCaixa, caixa)
            .subscribe(caixa => {
                swal("Enviada com sucesso!", "caixa alterado com sucesso", "success");
                this.router.navigate(['/caixa']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
