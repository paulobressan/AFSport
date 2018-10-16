import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CidadeService } from './cidade/cidade.service';
import { CidadesRoutingModule } from './cidades.routing.module';
import { CidadeListResolve } from './cidade-list/cidade-list.resolve';
import { CidadeFormResolve } from './cidade-form/cidade-form.resolve';
import { CidadeListModule } from './cidade-list/cidade-list.module';
import { CidadeFormModule } from './cidade-form/cidade-form.module';
import { EstadoAtivosResolve } from '../estados/estado/estado-ativos.resolve';
import { EstadoService } from '../estados/estado/estado.service';

@NgModule({
    imports: [
        CommonModule,
        CidadesRoutingModule,
        CidadeListModule,
        CidadeFormModule
    ],
    providers: [
        CidadeService,
        CidadeListResolve,
        CidadeFormResolve,
        EstadoAtivosResolve,
        EstadoService
    ],
})
export class CidadesModule { }