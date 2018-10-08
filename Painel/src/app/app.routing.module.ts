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
        loadChildren: './estados/estados.module#EstadosModule'
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