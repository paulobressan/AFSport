import { Component, OnInit, Input, OnChanges, ViewChild, ElementRef } from '@angular/core';
import { SimpleChanges } from '@angular/core';
import swal from 'sweetalert';

import { Produto } from '../produto/produto';
import { EstoqueService } from '../../estoques/estoque/estoque.service';
import { Estoque } from '../../estoques/estoque/estoque';

@Component({
    selector: 'af-produto-gerar-estoque',
    templateUrl: './produto-gerar-estoque.component.html'
})
export class ProdutoGerarEstoqueComponent {
    @ViewChild('produtoInput') produtoInput: ElementRef<HTMLSelectElement>;
    @Input() produtos: Produto[];

    constructor(private estoqueService: EstoqueService) { }

    gerarEstoque() {
        this.estoqueService.gerarEstoque(parseInt(this.produtoInput.nativeElement.value))
        .subscribe(() =>
            swal("Enviada com sucesso!", "Estoque gerado com sucesso", "success"), err =>
            swal("Problemas para enviar!", err.error.msg, "error"));
    }
}
