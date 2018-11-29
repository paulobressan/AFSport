package com.android.rafaelalves.afsport.activity.adapter;

import android.support.annotation.NonNull;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.model.Pedido;

import java.util.ArrayList;
import java.util.List;

public class AdapterPedido extends RecyclerView.Adapter<AdapterPedido.ViewHolderPedido> {
    private List<Pedido> listaPedidos;

    public AdapterPedido() {
        this.listaPedidos = new ArrayList<>();
    }

    public void setListaPedidos(List<Pedido> listaPedidos) {
        this.listaPedidos = listaPedidos;
        this.notifyDataSetChanged();
    }

    @NonNull
    @Override
    public ViewHolderPedido onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View itemListaPedido = LayoutInflater.from(parent.getContext()).inflate(R.layout.vendas_adapter, parent, false);
        return new ViewHolderPedido(itemListaPedido);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolderPedido holder, int position) {

        Pedido pedido = listaPedidos.get(position);

        holder.data.setText(pedido.getDataString());
        holder.codigo.setText(String.valueOf(pedido.getIdPedido()));
        holder.valorTotal.setText("R$: " + String.valueOf(pedido.getValorTotal()));
        holder.cliente.setText(pedido.getCliente().getNome());
        holder.status.setText(pedido.getStatusString());
    }

    @Override
    public int getItemCount() {

        return listaPedidos.size();
    }

    public class ViewHolderPedido extends RecyclerView.ViewHolder {

        TextView data;
        TextView codigo;
        TextView valorTotal;
        TextView cliente;
        TextView status;


        public ViewHolderPedido(View itemView) {
            super(itemView);
            data = itemView.findViewById(R.id.txtData);
            codigo = itemView.findViewById(R.id.txtCodigo);
            valorTotal = itemView.findViewById(R.id.txtValorTotal);
            cliente = itemView.findViewById(R.id.txtCliente);
            status = itemView.findViewById(R.id.txtStatus);
        }

    }
}
