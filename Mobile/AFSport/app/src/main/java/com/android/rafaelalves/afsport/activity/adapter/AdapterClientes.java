package com.android.rafaelalves.afsport.activity.adapter;

import android.support.annotation.NonNull;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.model.Cliente;

import java.util.List;


public class AdapterClientes extends RecyclerView.Adapter<AdapterClientes.ViewHolderCliente> {

    private List<Cliente> listaClientes;

    public AdapterClientes(List<Cliente> lista ) {
        this.listaClientes = lista;
    }

    @NonNull
    @Override
    public ViewHolderCliente onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View itemListaCliente = LayoutInflater.from(parent.getContext()).inflate(R.layout.clientes_adapter, parent, false);
        return new ViewHolderCliente(itemListaCliente);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolderCliente holder, int position) {

        Cliente cliente = listaClientes.get(position);

        holder.nome.setText(cliente.getNome());
        holder.codigo.setText(cliente.getIdCliente());
        holder.email.setText(cliente.getEmail());


    }

    @Override
    public int getItemCount() {

        return listaClientes.size();
    }

    public class ViewHolderCliente extends RecyclerView.ViewHolder{

        TextView nome;
        TextView codigo;
        TextView email;

        public ViewHolderCliente(View itemView) {
            super(itemView);
            nome = itemView.findViewById(R.id.txtNomeCliente);
            codigo = itemView.findViewById(R.id.txtCodigoCliente);
            email = itemView.findViewById(R.id.txtEmailCliente);
        }
    }

}
