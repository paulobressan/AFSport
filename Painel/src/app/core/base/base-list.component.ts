export interface BaseListComponent<T> {
    ativarInativar(isAtivo: boolean, obj: T);
    remover(obj: T);
    listar();
    alterar(obj: T);
}