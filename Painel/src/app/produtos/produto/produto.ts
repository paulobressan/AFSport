import { Categoria } from "../../categorias/categoria/categoria";

export interface Produto {
    idProduto: number;
    nome: string;
    descricao: string;
    valorCompra: number;
    valorVenda: number;
    idCategoria: number;
    categoria: Categoria;
    isAtivo: boolean;
}