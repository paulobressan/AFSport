import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EstoqueService } from './estoque/estoque.service';
import { EstoqueListResolve } from './estoque-list/estoque-list.resolve';
import { EstoqueListModule } from './estoque-list/estoque-list.module';
import { EstoquesRoutingModule } from './estoques.routing.module';

@NgModule({
    imports: [ 
        CommonModule,
        EstoquesRoutingModule,
        EstoqueListModule
    ],
    providers: [
        EstoqueService,
        EstoqueListResolve
    ]
})
export class EstoquesModule {}