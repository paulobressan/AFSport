package com.android.rafaelalves.afsport.activity.activity;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.DividerItemDecoration;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.widget.LinearLayout;
import android.widget.Toast;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.adapter.AdapterCaixa;
import com.android.rafaelalves.afsport.activity.model.Caixa;
import com.android.rafaelalves.afsport.activity.web.WebClient;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;


public class CaixaActivity extends AppCompatActivity {

    private final WebClient webClient;
    SharedPreferences preference;
    private AdapterCaixa adapterCaixas;
    private RecyclerView recyclerView;
    private Caixa caixaSelecionado;

    public CaixaActivity() {
        this.webClient = new WebClient();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_caixa);

        preference = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());

        recyclerView = findViewById(R.id.recyclerCaixas);
        this.CarregarLista();
        this.listarCaixas();

    }

    public void listarCaixas() {
        String key_auth = preference.getString("KEY_AUTH", "");
        this.webClient.getAllCaixas(key_auth).enqueue(new Callback<List<Caixa>>() {
            @Override
            public void onResponse(@NonNull Call<List<Caixa>> call, @NonNull Response<List<Caixa>> response) {
                adapterCaixas.setListaCaixas(response.body());
            }

            @Override
            public void onFailure(@NonNull Call<List<Caixa>> call, @NonNull Throwable t) {
                Toast.makeText(
                        getApplicationContext(),
                        t.getMessage(),
                        Toast.LENGTH_SHORT
                ).show();
            }
        });
    }

    private void CarregarLista() {
        adapterCaixas = new AdapterCaixa();
        RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(getApplicationContext());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setHasFixedSize(true);
        recyclerView.addItemDecoration(new DividerItemDecoration(this, LinearLayout.VERTICAL));
        recyclerView.setAdapter(adapterCaixas);
    }
}
