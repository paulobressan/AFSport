import { Estado } from "../../estados/estado/estado";

export interface Cidade {
    idCidade: number;
    nome: string;
    idEstado: number;
    estado: Estado;
    isAtivo: boolean;
}