import { Produto } from "src/app/produtos/produto/produto";
import { Pedido } from "./pedido";

export interface PedidoItem {
    idItemPedido: number,
    quantidade: number,
    idProduto: number,
    produto: Produto,
    pedidio: Pedido,
    isAtivo: boolean,
}