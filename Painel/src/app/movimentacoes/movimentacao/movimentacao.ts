import { Usuario } from "src/app/usuarios/usuario/usuario";
import { Operacao } from "src/app/operacoes/operacao/operacao";

export interface Movimentacao {
    idMovimentacao: number;
    valor: number;
    data: Date;
    idUsuario: number;
    usuario: Usuario;
    idOperacao: number;
    operacao: Operacao;
}