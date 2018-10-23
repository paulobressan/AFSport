import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Movimentacao } from '../movimentacao/movimentacao';
import { MovimentacaoService } from '../movimentacao/movimentacao.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    templateUrl: './movimentacao-form.component.html'
})
export class MovimentacaoFormComponent implements OnInit {
    @ViewChild('valorInput') valorInput: ElementRef<HTMLInputElement>;
    movimentacaoForm: FormGroup;
    movimentacao: Movimentacao;

    constructor(
        private formBuilder: FormBuilder,
        private movimentacaoService: MovimentacaoService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.movimentacao = this.activatedRoute.snapshot.data.movimentacao;
        this.movimentacaoForm = this.formBuilder.group({
            idMovimentacao: [this.movimentacao ? this.movimentacao.idMovimentacao : 0],
            valor: [this.movimentacao ? this.movimentacao.valor : 0, [
                Validators.required
            ]],
            idOperacao: [this.movimentacao && this.movimentacao.operacao ? this.movimentacao.operacao.idOperacao : 0, [
                Validators.required
            ]]
        });
        this.valorInput.nativeElement.focus();
    }

    salvar() {
        var movimentacao = this.movimentacaoForm.getRawValue() as Movimentacao;
        if (movimentacao.idMovimentacao)
            this.alterar(movimentacao);
        else
            this.inserir(movimentacao);
    }

    inserir(movimentacao: Movimentacao) {
        this.movimentacaoService.inserir(movimentacao)
            .subscribe(movimentacao => {
                swal("Enviada com sucesso!", "movimentacao cadastrada com sucesso", "success");
                this.router.navigate(['/movimentacao']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(movimentacao: Movimentacao) {
        this.movimentacaoService.alterar(movimentacao.idMovimentacao, movimentacao)
            .subscribe(movimentacao => {
                swal("Enviada com sucesso!", "movimentacao alterada com sucesso", "success");
                this.router.navigate(['/movimentacao']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
