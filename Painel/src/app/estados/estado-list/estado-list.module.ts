import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { EstadoListComponent } from './estado-list.component';
import { IsAtivoModule } from '../../shared/components/is-ativo/is-ativo.module';

@NgModule({
    declarations: [EstadoListComponent],
    imports: [ 
        CommonModule,
        RouterModule,
        IsAtivoModule
    ]
})
export class EstadoListModule {}