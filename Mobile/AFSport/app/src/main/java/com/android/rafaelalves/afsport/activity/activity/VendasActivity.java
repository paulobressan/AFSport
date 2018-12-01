package com.android.rafaelalves.afsport.activity.activity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.preference.PreferenceManager;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.DividerItemDecoration;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.Toast;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.adapter.AdapterPedido;
import com.android.rafaelalves.afsport.activity.model.Pedido;
import com.android.rafaelalves.afsport.activity.web.WebClient;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class VendasActivity extends AppCompatActivity {

    private final WebClient webClient;
    SharedPreferences preference;
    private AdapterPedido adapterPedido;
    private RecyclerView recyclerView;

    public VendasActivity() {
        this.webClient = new WebClient();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_vendas);

        preference = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());

        recyclerView = findViewById(R.id.recyclerVendas);
        this.CarregarLista();
        this.listarCaixas();
    }

    public void listarCaixas() {
        String key_auth = preference.getString("KEY_AUTH", "");
        this.webClient.getAllPedidos(key_auth).enqueue(new Callback<List<Pedido>>() {
            @Override
            public void onResponse(@NonNull Call<List<Pedido>> call, @NonNull Response<List<Pedido>> response) {
                adapterPedido.setListaPedidos(response.body());
            }

            @Override
            public void onFailure(@NonNull Call<List<Pedido>> call, @NonNull Throwable t) {
                Toast.makeText(
                        getApplicationContext(),
                        t.getMessage(),
                        Toast.LENGTH_SHORT
                ).show();
            }
        });
    }

    private void CarregarLista() {
        adapterPedido = new AdapterPedido();
        RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(getApplicationContext());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setHasFixedSize(true);
        recyclerView.addItemDecoration(new DividerItemDecoration(this, LinearLayout.VERTICAL));
        recyclerView.setAdapter(adapterPedido);
    }
    public void CadastrarPedido(View view) {
        startActivity(new Intent(this, CadastrarPedidoActivity.class));
    }

    public void EditarPedido(View view) {

    }

    public void DeletarPedido(View view) {

    }
}
