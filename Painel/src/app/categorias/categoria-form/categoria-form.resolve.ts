import { Resolve } from "@angular/router";
import { Observable } from "rxjs";
import { ActivatedRouteSnapshot } from "@angular/router";
import { RouterStateSnapshot } from "@angular/router";

import { Categoria } from "../categoria/categoria";
import { CategoriaService } from "../categoria/categoria.service";
import { Injectable } from "@angular/core";

@Injectable()
export class CategoriaFormResolve implements Resolve<Observable<Categoria>> {
    constructor(private categoriaService: CategoriaService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Categoria> | Observable<Observable<Categoria>> | Promise<Observable<Categoria>> {
        const id = route.params.id;
        if (id)
            return this.categoriaService.listarPorId(id);
    }
}