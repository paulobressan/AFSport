package com.android.rafaelalves.afsport.activity.activity;

import android.content.SharedPreferences;
import android.preference.PreferenceManager;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.model.Cliente;
import com.android.rafaelalves.afsport.activity.web.API;
import com.android.rafaelalves.afsport.activity.web.WebClient;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class CadastrarClienteActivity extends AppCompatActivity {
    private EditText nome;
    private EditText email;
    private EditText logradouro;
    private EditText numero;
    private EditText bairro;
    private Spinner spinnerCidades;
    private Cliente cliente;

    private WebClient webClient;
    private SharedPreferences preferences;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadastrar_cliente);
        preferences = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());

        cliente = (Cliente) getIntent().getExtras().get("cliente");

        nome = findViewById(R.id.txtNome);
        email = findViewById(R.id.txtEmail);
        logradouro = findViewById(R.id.txtLogradouro);
        numero = findViewById(R.id.txtNumero);
        bairro = findViewById(R.id.txtBairro);
        spinnerCidades = findViewById(R.id.spinnerCidades);

        webClient = new WebClient();
    }

    private void listarCidades(){
        String key_auth = preferences.getString("KEY_AUTH", "");
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

    private void CarregarCidades(){
        ArrayAdapter<Cidade> adapter = new ArrayAdapter<>(this, android.R.layout.simple_spinner_dropdown_item, items);
    }
}
