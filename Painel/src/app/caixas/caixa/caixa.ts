import { Usuario } from "src/app/usuarios/usuario/usuario";

export interface Caixa {
    idCaixa: number;
    valorInicial: number;
    data: Date;
    usuario: Usuario
}