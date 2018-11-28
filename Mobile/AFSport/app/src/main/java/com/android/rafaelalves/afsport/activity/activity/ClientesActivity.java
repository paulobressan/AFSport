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
import android.widget.TextView;
import android.widget.Toast;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.RecyclerItemClickListener;
import com.android.rafaelalves.afsport.activity.adapter.AdapterClientes;
import com.android.rafaelalves.afsport.activity.model.Cliente;
import com.android.rafaelalves.afsport.activity.web.WebClient;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class ClientesActivity extends AppCompatActivity {

    private final WebClient webClient;
    SharedPreferences preference;
    private AdapterClientes adapterClientes;
    private Cliente clienteSelecionado;

    private RecyclerView recyclerView;

    public ClientesActivity() {
        this.webClient = new WebClient();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_clientes);

        preference = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());

        recyclerView = findViewById(R.id.recyclerClientes);

        this.listarClientes();
        this.CarregarLista();

        recyclerView.addOnItemTouchListener(
                new RecyclerItemClickListener(
                        getApplicationContext(),
                        recyclerView,
                        new RecyclerItemClickListener.OnItemClickListener() {
                            @Override
                            public void onItemClick(View view, int position) {
                                clienteSelecionado = adapterClientes.getItemPosition(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Cliente Selecionado: " + clienteSelecionado.getNome(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onLongItemClick(View view, int position) {
                                clienteSelecionado = adapterClientes.getItemPosition(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Cliente Selecionado: " + clienteSelecionado.getNome(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                            }
                        }
                )
        );

        Button addCliente = findViewById(R.id.btnAddCliente);
        Button editarCliente = findViewById(R.id.btnEditarProduto);
        Button apagarCliente = findViewById(R.id.btnApagarProduto);
        TextView txtClientes = findViewById(R.id.textViewCliente);
    }

    public void CadastrarCliente(View view) {
        Intent intent = new Intent(this, CadastrarClienteActivity.class);
        intent.putExtra("cliente", clienteSelecionado);
        startActivity(intent);
    }

    public void EditarCliente(View view) {

    }

    public void DeletarCliente(View view) {

    }

    public void listarClientes() {
        String key_auth = preference.getString("KEY_AUTH", "");
        this.webClient.getAllClientes(key_auth).enqueue(new Callback<List<Cliente>>() {
            @Override
            public void onResponse(@NonNull Call<List<Cliente>> call, @NonNull Response<List<Cliente>> response) {
                adapterClientes.setListaClientes(response.body());
            }

            @Override
            public void onFailure(@NonNull Call<List<Cliente>> call, @NonNull Throwable t) {
                Toast.makeText(
                        getApplicationContext(),
                        t.getMessage(),
                        Toast.LENGTH_SHORT
                ).show();
            }
        });
    }

    private void CarregarLista() {
        // Configuração Adapter

        adapterClientes = new AdapterClientes();

        // Configuração do Recyclerview

        RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(getApplicationContext());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setHasFixedSize(true);
        recyclerView.addItemDecoration(new DividerItemDecoration(this, LinearLayout.VERTICAL));
        recyclerView.setAdapter(adapterClientes);
    }
}
