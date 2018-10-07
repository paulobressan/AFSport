import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ProdutosRoutingModule } from "./produtos.routing.module";
import { ProdutoListResolve } from "./produto-list/produto-list.resolve";
import { ProdutoListModule } from "./produto-list/produto-list.module";
import { ProdutoFormModule } from "./produto-form/produto-form.module";
import { CategoriasAtivasResolve } from "../categorias/categoria/categorias-ativas.resolve";
import { ProdutoFormResolve } from "./produto-form/produto-form.resolve";
import { ProdutoService } from "./produto/produto.service";
import { CategoriaService } from "../categorias/categoria/categoria.service";

@NgModule({
    imports:[
        CommonModule,
        ProdutoListModule,
        ProdutosRoutingModule,
        ProdutoFormModule
    ],
    providers:[
        ProdutoFormResolve,
        ProdutoListResolve,
        ProdutoService,
        CategoriaService,
        CategoriasAtivasResolve
    ]
})
export class ProdutosModule{}