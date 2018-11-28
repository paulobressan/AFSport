package com.android.rafaelalves.afsport.activity.model;

import java.io.Serializable;

public class Produto implements Serializable {

    private int idProduto;
    private String nome;
    private String descricao;
    private double valorCompra;
    private double valorVenda;
    private Categoria categoria;
    private boolean isAtivo;

    public Produto(int idProduto, String nome, String descricao, double valorCompra, double valorVenda, Categoria categoria, boolean isAtivo) {
        this.idProduto = idProduto;
        this.nome = nome;
        this.descricao = descricao;
        this.valorCompra = valorCompra;
        this.valorVenda = valorVenda;
        this.categoria = categoria;
        this.isAtivo = isAtivo;
    }

    public int getIdProduto() {
        return idProduto;
    }

    public void setIdProduto(int idProduto) {
        this.idProduto = idProduto;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String nescricao) {
        this.descricao = nescricao;
    }

    public double getValorCompra() {
        return valorCompra;
    }

    public void setValorCompra(double valorCompra) {
        this.valorCompra = valorCompra;
    }

    public double getValorVenda() {
        return valorVenda;
    }

    public void setValorVenda(double valorVenda) {
        this.valorVenda = valorVenda;
    }

    public Categoria getCategoria() {
        return categoria;
    }

    public void setCategoria(Categoria categoria) {
        this.categoria = categoria;
    }

    public boolean isAtivo() {
        return isAtivo;
    }

    public void setAtivo(boolean ativo) {
        isAtivo = ativo;
    }
}
