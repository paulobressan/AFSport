import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ProdutosRoutingModule } from "./produtos.routing.module";
import { ProdutoListResolve } from "./produto-list/produto-list.resolve";
import { ProdutoListModule } from "./produto-list/produto-list.module";

@NgModule({
    imports:[
        CommonModule,
        ProdutoListModule,
        ProdutosRoutingModule
    ],
    providers:[
        ProdutoListResolve
    ]
})
export class ProdutosModule{}