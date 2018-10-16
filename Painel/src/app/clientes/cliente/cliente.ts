import { Cidade } from "src/app/cidades/cidade/cidade";

export interface Cliente {
    idCliente: number;
    idCidade: number;
    cidade: Cidade;
    nome : string;
    logradouro: string;
    bairro: string;
    numero: number;
    email: string;
    isAtivo: boolean;
}