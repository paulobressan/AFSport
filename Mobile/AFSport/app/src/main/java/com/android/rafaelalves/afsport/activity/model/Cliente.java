package com.android.rafaelalves.afsport.activity.model;

import java.io.Serializable;

public class Cliente implements Serializable {
    private int idCliente;
    private String nome;
    private String email;
    private Boolean isAtivo;
    private String logradouro;
    private String bairro;
    private int numero;
    private int idCidade;

    public Cliente(int idCliente, String nome, String email) {
        this.idCliente = idCliente;
        this.nome = nome;
        this.email = email;
    }

    public Cliente(String nome, String email, Boolean isAtivo, String logradouro, String bairro, int numero, int idCidade) {
        this.nome = nome;
        this.email = email;
        this.isAtivo = isAtivo;
        this.logradouro = logradouro;
        this.bairro = bairro;
        this.numero = numero;
        this.idCidade = idCidade;
    }

    public int getIdCliente() {
        return idCliente;
    }

    public void setIdCliente(int idCliente) {
        this.idCliente = idCliente;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public Boolean getAtivo() {
        return isAtivo;
    }

    public void setAtivo(Boolean ativo) {
        isAtivo = ativo;
    }

    public String getLogradouro() {
        return logradouro;
    }

    public void setLogradouro(String logradouro) {
        this.logradouro = logradouro;
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        this.bairro = bairro;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public int getIdCidade() {
        return idCidade;
    }

    public void setIdCidade(int idCidade) {
        this.idCidade = idCidade;
    }
}
