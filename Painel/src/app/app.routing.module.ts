import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './login/login.component';
import { AuthGuard } from './core/guards/auth.guard';
import { LoginGuard } from './core/guards/login.guard';

const routes: Routes = [
    {
        path: '',
        loadChildren: './home/home.module#HomeModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'categoria',
        loadChildren: './categorias/categorias.module#CategoriasModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'produto',
        loadChildren: './produtos/produtos.module#ProdutosModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'estado',
        loadChildren: './estados/estados.module#EstadosModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'cidade',
        loadChildren: './cidades/cidades.module#CidadesModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'cliente',
        loadChildren: './clientes/clientes.module#ClientesModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'estoque',
        loadChildren: './estoques/estoques.module#EstoquesModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'caixa',
        loadChildren: './caixas/caixas.module#CaixasModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'operacao',
        loadChildren: './operacoes/operacoes.module#OperacoesModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'movimentacao',
        loadChildren: './movimentacoes/movimentacoes.module#MovimentacoesModule',
        canActivate: [AuthGuard]
    },
    {
        path: 'login',
        component: LoginComponent,
        canActivate: [LoginGuard]
    }
]

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }