import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { Observable } from "rxjs";

import { BaseService } from "src/app/core/base/base.service";
import { Pedido } from "./pedido";
import { HttpClient } from "@angular/common/http";
import { PedidoItem } from "./pedido-item";

@Injectable()
export class PedidoService extends BaseService<Pedido> {
    constructor(private httpClient: HttpClient) {
        super(httpClient, environment.pedido);
    }

    listarItens(idPedido: number): Observable<PedidoItem[]> {
        return this.http.get<PedidoItem[]>(`${this.environment}/${idPedido}/itens-pedido`);
    }

    inserirItemPedido(idPedido: number, pedidoItem: PedidoItem): Observable<PedidoItem> {
        return this.http.post<PedidoItem>(`${this.environment}/${idPedido}/itens-pedido`, pedidoItem);
    }

    alterarItemPedido(idPedido: number, idPedidoItem: number, pedidoItem: PedidoItem): Observable<PedidoItem> {
        return this.http.post<PedidoItem>(`${this.environment}/${idPedido}/itens-pedido/${idPedidoItem}`, pedidoItem);
    }
}