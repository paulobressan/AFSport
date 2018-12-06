import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Pedido } from '../pedido/pedido';
import { Operacao } from 'src/app/operacoes/operacao/operacao';
import { PedidoService } from '../pedido/pedido.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Movimentacao } from 'src/app/movimentacoes/movimentacao/movimentacao';

@Component({
    templateUrl: './pedido-finalizar.component.html'
})
export class PedidoFinalizarComponent implements OnInit {
    @ViewChild('idOperacao') idOperacao: ElementRef<HTMLInputElement>;

    pedidoForm: FormGroup;
    pedido: Pedido;
    operacoes: Operacao[];

    constructor(
        private formBuilder: FormBuilder,
        private pedidoService: PedidoService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.pedido = this.activatedRoute.snapshot.data.pedido;
        this.operacoes = this.activatedRoute.snapshot.data.operacoes;
        this.pedidoForm = this.formBuilder.group({
            idPedido: [this.pedido ? this.pedido.idPedido : 0],
            idOperacao: [1, Validators.required],
            valor: [0, Validators.required]
        });
        this.idOperacao.nativeElement.disabled = true;
    }

    salvar() {
        let movimentacao = this.pedidoForm.getRawValue() as Movimentacao;
        this.pedidoService.finalizarPedido(this.pedidoForm.get('idPedido').value, movimentacao)
            .subscribe(pedido => {
                swal("Enviada com sucesso!", "Pedido finalizado com sucesso", "success");
                this.router.navigate(['/pedido']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
