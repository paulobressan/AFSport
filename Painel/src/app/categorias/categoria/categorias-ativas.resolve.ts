import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';
import { Categoria } from './categoria';
import { CategoriaService } from './categoria.service';

@Injectable()
export class CategoriasAtivasResolve implements Resolve<Observable<Categoria[]>> {

    constructor(private categoriaService: CategoriaService) { }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        return this.categoriaService.listarAtivos();
    }
}
