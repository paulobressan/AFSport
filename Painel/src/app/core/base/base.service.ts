import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

export class BaseService<T> {
    constructor(protected http: HttpClient, protected environment: string) { }

    listar(): Observable<T[]> {
        return this.http.get<T[]>(this.environment);
    }

    listarPorId(id: number): Observable<T> {
        return this.http.get<T>(`${this.environment}/${id}`);
    }

    inserir(obj: T): Observable<T> {
        return this.http.post<T>(this.environment, obj);
    }

    alterar(id: number, obj: T): Observable<T> {
        return this.http.put<T>(`${this.environment}/${id}`, obj);
    }

    remover(id: number): Observable<any> {
        return this.http.delete(`${this.environment}/${id}`);
    }

    ativarInativar(id: number, obj: T): Observable<any> {
        return this.http.put(`${this.environment}/ativar-inativar/${id}`, obj);
    }
}