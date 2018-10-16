import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { BaseFormComponent } from '../../core/base/base-form.component';
import { Cliente } from '../cliente/cliente';
import { ClienteService } from '../cliente/cliente.service';
import { Cidade } from 'src/app/cidades/cidade/cidade';

@Component({
    templateUrl: './cliente-form.component.html'
})
export class ClienteFormComponent implements BaseFormComponent<Cliente>, OnInit {
    clienteForm: FormGroup;
    cliente: Cliente;
    cidades: Cidade[];

    constructor(
        private formBuilder: FormBuilder,
        private clienteService: ClienteService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.cidades = this.activatedRoute.snapshot.data.cidades;
        this.cliente = this.activatedRoute.snapshot.data.cliente;
        this.clienteForm = this.formBuilder.group({
            idCliente: [this.cliente ? this.cliente.idCliente : 0],
            idCidade: [this.cliente && this.cliente.cidade ? this.cliente.cidade.idCidade : 1, [
                Validators.required
            ]],
            nome: [this.cliente ? this.cliente.nome : '', [
                Validators.required,
                Validators.maxLength(100)
            ]],
            logradouro: [this.cliente ? this.cliente.logradouro : '', [
                Validators.required,
                Validators.maxLength(255)
            ]],
            bairro: [this.cliente ? this.cliente.bairro : '', [
                Validators.required,
                Validators.maxLength(50)
            ]],
            numero: [this.cliente ? this.cliente.numero : ''],
            email: [this.cliente ? this.cliente.email : '', [
                Validators.maxLength(255),
                Validators.email
            ]],
            isAtivo: [this.cliente ? this.cliente.isAtivo : true]
        })
    }

    salvar() {
        var cliente: Cliente = this.clienteForm.getRawValue() as Cliente;
        if (cliente.idCliente)
            this.alterar(cliente);
        else
            this.inserir(cliente);
    }

    inserir(cliente: Cliente) {
        this.clienteService.inserir(cliente)
            .subscribe(Cliente => {
                swal("Enviada com sucesso!", "Cliente cadastrado com sucesso", "success");
                this.router.navigate(['/Cliente']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }

    alterar(cliente: Cliente) {
        this.clienteService.alterar(cliente.idCliente, cliente)
            .subscribe(Cliente => {
                swal("Enviada com sucesso!", "Cliente alterado com sucesso", "success");
                this.router.navigate(['/Cliente']);
            }, err => {
                swal("Problemas para enviar!", err.error.msg, "error");
            });
    }
}
