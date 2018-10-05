import { Resolve } from "@angular/router";
import { Observable } from "rxjs";
import { ActivatedRouteSnapshot } from "@angular/router";
import { RouterStateSnapshot } from "@angular/router";

import { Categoria } from "./categoria";
import { CategoriaService } from "./categoria.service";
import { Injectable } from "@angular/core";

@Injectable()
export class CategoriaResolver implements Resolve<Observable<Categoria[]>>{
    constructor(private categoriaService: CategoriaService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Categoria[]> | Observable<Observable<Categoria[]>> | Promise<Observable<Categoria[]>> {
        return this.categoriaService.listarCategorias();
    }
}