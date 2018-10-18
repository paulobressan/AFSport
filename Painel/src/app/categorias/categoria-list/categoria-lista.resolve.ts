import { Resolve } from "@angular/router";
import { Observable } from "rxjs";
import { ActivatedRouteSnapshot } from "@angular/router";
import { RouterStateSnapshot } from "@angular/router";

import { Injectable } from "@angular/core";
import { CategoriaService } from "../categoria/categoria.service";
import { Categoria } from "../categoria/categoria";

@Injectable()
export class CategoriaListResolver implements Resolve<Observable<Categoria[]>>{
    constructor(private categoriaService: CategoriaService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Categoria[]> | any {
        return this.categoriaService.listar();
    }
}