import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { IsAtivoModule } from 'src/app/shared/components/is-ativo/is-ativo.module';
import { ClienteListComponent } from './cliente-list.component';

@NgModule({
    declarations: [ClienteListComponent],
    imports: [
        CommonModule,
        RouterModule,
        IsAtivoModule
    ]
})
export class ClienteListModule { }