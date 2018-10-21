import { Component, OnInit, ViewChild, ElementRef, Input } from '@angular/core';
import { BaseFormComponent } from 'src/app/core/base/base-form.component';
import { Operacao } from '../operacao/operacao';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { OperacaoService } from '../operacao/operacao.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: './operacao-form.component.html'
})
export class OperacaoFormComponent implements BaseFormComponent<Operacao>, OnInit {
    @ViewChild('nomeInput') nomeInput: ElementRef<HTMLInputElement>;
    operacaoForm: FormGroup;
    operacao: Operacao;

    constructor(
        private formBuilder: FormBuilder,
        private operacaoService: OperacaoService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.operacao = this.activatedRoute.snapshot.data.operacao;
        this.operacaoForm = this.formBuilder.group({
            idoperacao: [this.operacao ? this.operacao.idOperacao : 0],
            nome: [this.operacao ? this.operacao.nome : '', [
                Validators.required,
                Validators.maxLength(50)
            ]],
            descricao: [this.operacao ? this.operacao.descricao : '', [
                Validators.maxLength(255)
            ]],
            isAtivo: [this.operacao ? this.operacao.isAtivo : true]
        });
        this.nomeInput.nativeElement.focus();
    }

    salvar() {
        var operacao = this.operacaoForm.getRawValue() as Operacao;
        if (operacao.idOperacao)
            this.alterar(operacao);
        else
            this.inserir(operacao);
    }

    inserir(operacao: Operacao) {
        this.operacaoService.inserir(operacao)
            .subscribe(operacao => {
                swal("Enviada com sucesso!", "Operação cadastrada com sucesso", "success");
                this.router.navigate(['/operacao']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(operacao: Operacao) {
        this.operacaoService.alterar(operacao.idOperacao, operacao)
            .subscribe(operacao => {
                swal("Enviada com sucesso!", "Operação alterada com sucesso", "success");
                this.router.navigate(['/operacao']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
