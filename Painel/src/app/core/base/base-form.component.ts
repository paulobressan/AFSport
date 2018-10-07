export interface BaseFormComponent<T> {
    salvar();
    inserir(obj: T);
    alterar(obj: T);
}