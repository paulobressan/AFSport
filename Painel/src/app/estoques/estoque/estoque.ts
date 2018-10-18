import { Produto } from "src/app/produtos/produto/produto";
import { Usuario } from "src/app/usuarios/usuario/usuario";

export interface Estoque {
    idEstoque: number;
    quantidade: number;
    idProduto: number;
    produto: Produto;
    idUsuario: number;
    usuario: Usuario;
    isAtivo: boolean;
}