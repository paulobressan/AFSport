package com.android.rafaelalves.afsport.activity.adapter;

import android.support.annotation.NonNull;
import android.support.v7.widget.RecyclerView;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.model.Caixa;

import java.util.ArrayList;
import java.util.List;

public class AdapterCaixa extends RecyclerView.Adapter<AdapterCaixa.ViewHolderCaixa> {
    private List<Caixa> listaCaixas;

    public AdapterCaixa()
    {
        this.listaCaixas = new ArrayList<>();
    }

    public void setListaCaixas(List<Caixa> listaCaixas)
    {
        this.listaCaixas = listaCaixas;
        this.notifyDataSetChanged();
    }

    @NonNull
    @Override
    public ViewHolderCaixa onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View itemListaCaixa = LayoutInflater.from(parent.getContext()).inflate(R.layout.caixa_adapter, parent, false);
        return new ViewHolderCaixa(itemListaCaixa);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolderCaixa holder, int position) {

        Caixa caixa = listaCaixas.get(position);

        holder.data.setText(caixa.getDataString());
        holder.codigo.setText(String.valueOf(caixa.getIdCaixa()));
        holder.valorInicial.setText("R$: " + String.valueOf(caixa.getValorInicial()));
        holder.usuario.setText(caixa.getUsuario().getNome());
    }

    @Override
    public int getItemCount() {

        return listaCaixas.size();
    }

    public class ViewHolderCaixa extends RecyclerView.ViewHolder {

        TextView data;
        TextView codigo;
        TextView valorInicial;
        TextView usuario;

        public ViewHolderCaixa(View itemView) {
            super(itemView);
            data = itemView.findViewById(R.id.txtData);
            codigo = itemView.findViewById(R.id.txtCodigo);
            valorInicial = itemView.findViewById(R.id.txtValorInicial);
            usuario = itemView.findViewById(R.id.txtUsuario);
        }

    }
    public Caixa getItemPosition(int position){
        return listaCaixas.get(position);
    }


}
