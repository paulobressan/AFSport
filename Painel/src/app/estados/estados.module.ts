import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EstadosRoutingModule } from './estados.routing.module';
import { EstadoService } from './estado/estado.service';
import { EstadoListModule } from './estado-list/estado-list.module';
import { EstadoListResolve } from './estado-list/estado-list.resolve';
import { EstadoFormModule } from './estado-form/estado-form.module';
import { EstadoFormResolve } from './estado-form/estado-form.resolve';

@NgModule({
    imports: [
        CommonModule,
        EstadosRoutingModule,
        EstadoListModule,
        EstadoFormModule
    ],
    providers: [
        EstadoService,
        EstadoListResolve,
        EstadoFormResolve
    ],
})
export class EstadosModule { }