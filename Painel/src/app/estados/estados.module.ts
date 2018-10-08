import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EstadosRoutingModule } from './estados.routing.module';
import { EstadoService } from './estado/estado.service';
import { EstadoListModule } from './estado-list/estado-list.module';
import { EstadoListResolve } from './estado-list/estado-list.resolve';

@NgModule({
    imports: [
        CommonModule,
        EstadosRoutingModule,
        EstadoListModule
    ],
    providers: [
        EstadoService,
        EstadoListResolve
    ],
})
export class EstadosModule { }