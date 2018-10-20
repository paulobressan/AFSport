export interface BaseListComponent<T> {
    remover(obj: T);
    listar();
    alterar(obj: T);
}