package com.android.rafaelalves.afsport.activity.activity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.DividerItemDecoration;
import android.support.v7.widget.LinearLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.Toast;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.RecyclerItemClickListener;
import com.android.rafaelalves.afsport.activity.adapter.AdapterProdutos;
import com.android.rafaelalves.afsport.activity.model.Produto;
import com.android.rafaelalves.afsport.activity.web.WebClient;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class ProdutosActivity extends AppCompatActivity {


    private final WebClient webClient;
    SharedPreferences preference;
    private AdapterProdutos adapterProdutos;

    private RecyclerView recyclerView;

    public ProdutosActivity() {
        this.webClient = new WebClient();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_produtos);
        preference = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
        recyclerView = findViewById(R.id.recyclerProduto);
        this.listarProdutos();
        this.CarregarLista();

        recyclerView.addOnItemTouchListener(
                new RecyclerItemClickListener(
                        getApplicationContext(),
                        recyclerView,
                        new RecyclerItemClickListener.OnItemClickListener() {
                            @Override
                            public void onItemClick(View view, int position) {
                                Produto produtoSelecionado = adapterProdutos.getItemPosition(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Item Selecionado: " + produtoSelecionado.getNome(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onLongItemClick(View view, int position) {
                                Produto produto = adapterProdutos.getItemPosition(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Item Selecionado: " + produto.getNome(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                            }
                        }
                )
        );

        Button addProduto = findViewById(R.id.btnAddProduto);
        Button editarProduto = findViewById(R.id.btnEditarProduto);
        Button apagarProduto = findViewById(R.id.btnApagarProduto);
    }

    public void CadastrarProduto(View view) {
        startActivity(new Intent(this, CadastrarProdutoActivity.class));
    }

    public void EditarProduto(View view) {

    }

    public void DeletarProduto(View view) {

    }

    public void listarProdutos() {
        String key_auth = preference.getString("KEY_AUTH", "");
        this.webClient.getAllProdutos(key_auth).enqueue(new Callback<List<Produto>>() {
            @Override
            public void onResponse(@NonNull Call<List<Produto>> call, @NonNull Response<List<Produto>> response) {
                adapterProdutos.setListaProdutos(response.body());
            }

            @Override
            public void onFailure(@NonNull Call<List<Produto>> call, @NonNull Throwable t) {
                Toast.makeText(
                        getApplicationContext(),
                        t.getMessage(),
                        Toast.LENGTH_SHORT
                ).show();
            }
        });
    }

    private void CarregarLista() {
        adapterProdutos = new AdapterProdutos();

        RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(getApplicationContext());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setHasFixedSize(true);
        recyclerView.addItemDecoration(new DividerItemDecoration(this, LinearLayout.VERTICAL));
        recyclerView.setAdapter(adapterProdutos);

    }
}
