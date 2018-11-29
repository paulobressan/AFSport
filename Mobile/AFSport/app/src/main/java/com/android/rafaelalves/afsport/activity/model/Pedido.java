package com.android.rafaelalves.afsport.activity.model;

public class Pedido {
    private int idPedido;
    private Cliente cliente;
    private Usuario usuario;
    private String statusString;
    private float valorTotal;

    public String getStatusString() {
        return statusString;
    }

    public void setStatusString(String statusString) {
        statusString = statusString;
    }

    public float getValorTotal() {
        return valorTotal;
    }

    public void setValorTotal(float valorTotal) {
        this.valorTotal = valorTotal;
    }

    public String getDataString() {
        return dataString;
    }

    public void setDataString(String dataString) {
        this.dataString = dataString;
    }

    private String dataString;

    public int getIdPedido() {
        return idPedido;
    }

    public void setIdPedido(int idPedido) {
        this.idPedido = idPedido;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Usuario getUsuario() {
        return usuario;
    }

    public void setUsuario(Usuario usuario) {
        this.usuario = usuario;
    }

    /*public String getStatus() {
        switch (status) {
            case 0:
                return "Cancelado";
            case 1:
                return "Aberto";
            case 2:
                return "Finalizado";
            default:
                return "Error";
        }
    }

    public void setStatus(int status) {
        this.status = status;
    }*/
}
