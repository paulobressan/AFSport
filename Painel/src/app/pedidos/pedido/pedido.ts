import { Cliente } from "src/app/clientes/cliente/cliente";
import { Usuario } from "src/app/usuarios/usuario/usuario";
import { PedidoStatus } from "./status.enum";

export interface Pedido {
    idPedido: number,
    data: Date,
    idCliente: number,
    cliente: Cliente,
    idUsuario: number,
    usuario: Usuario,
    status: PedidoStatus,
}