import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { ProdutoListComponent } from "./produto-list/produto-list.component";
import { ProdutoListResolve } from "./produto-list/produto-list.resolve";
import { ProdutoFormComponent } from "./produto-form/produto-form.component";
import { CategoriasAtivasResolve } from "../categorias/categoria/categorias-ativas.resolve";
import { ProdutoFormResolve } from "./produto-form/produto-form.resolve";

const routes: Routes = [
    {
        path: '',
        component: ProdutoListComponent,
        resolve: {
            produtos: ProdutoListResolve
        }
    },
    {
        path: 'novo-produto',
        component: ProdutoFormComponent,
        resolve:{
            categorias: CategoriasAtivasResolve
        }
    },
    {
        path: 'alterar-produto/:id',
        component: ProdutoFormComponent,
        resolve:{
            categorias: CategoriasAtivasResolve,
            produto: ProdutoFormResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ProdutosRoutingModule { }