import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';

import { PedidoListComponent } from './pedido-list/pedido-list.component';
import { PedidoListResolve } from './pedido-list/pedido-list.revolve';

const routes: Routes = [
    {
        path: '',
        component: PedidoListComponent,
        resolve: {
            pedidos: PedidoListResolve
        }
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class PedidosRoutingModule { }
