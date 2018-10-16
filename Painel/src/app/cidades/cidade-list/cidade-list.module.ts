import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { CidadeListComponent } from './cidade-list.component';
import { IsAtivoModule } from '../../shared/components/is-ativo/is-ativo.module';
import { MensagemModule } from '../../shared/components/mensagem/mensagem.module';

@NgModule({
    declarations: [CidadeListComponent],
    imports: [
        CommonModule,
        RouterModule,
        IsAtivoModule        
    ]
})
export class CidadeListModule { }