import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientesRoutingModule } from './clientes.routing.module';
import { ClienteListModule } from './cliente-list/cliente-list.module';
import { ClienteService } from './cliente/cliente.service';
import { ClienteListResolve } from './cliente-list/cliente-list.resolve';
import { ClienteFormModule } from './cliente-form/cliente-form.module';
import { CidadeService } from '../cidades/cidade/cidade.service';
import { CidadeAtivasResolve } from '../cidades/cidade/cidade-ativas.resolve';

@NgModule({
    imports: [
        CommonModule,
        ClientesRoutingModule,
        ClienteListModule,
        ClienteFormModule
    ],
    providers: [
        ClienteService,
        ClienteListResolve,

        CidadeAtivasResolve,
        CidadeService
    ]
})
export class ClientesModule { }