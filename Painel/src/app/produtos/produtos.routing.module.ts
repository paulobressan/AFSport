import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { ProdutoListComponent } from "./produto-list/produto-list.component";
import { ProdutoListResolve } from "./produto-list/produto-list.resolve";

const routes: Routes = [
    {
        path: '',
        component: ProdutoListComponent,
        resolve: {
            produtos: ProdutoListResolve
        }
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ProdutosRoutingModule { }