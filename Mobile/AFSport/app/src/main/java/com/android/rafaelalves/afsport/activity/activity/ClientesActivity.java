package com.android.rafaelalves.afsport.activity.activity;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
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

import java.util.ArrayList;
import java.util.List;

public class ClientesActivity extends AppCompatActivity {

    private RecyclerView recyclerView;
    private List<Cliente> listaClientes = new ArrayList<>();


    private Button addCliente;
    private Button editarCliente;
    private Button apagarCliente;
    private TextView txtClientes;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_clientes);



        recyclerView = findViewById(R.id.recyclerClientes);

        //Listar Clientes

        this.listarClientes();

        // Configuração Adapter

        AdapterClientes adapterClientes = new AdapterClientes(listaClientes);

        // Configuração do Recyclerview

        RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(getApplicationContext());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setHasFixedSize(true);
        recyclerView.addItemDecoration(new DividerItemDecoration(this,LinearLayout.VERTICAL));
        recyclerView.setAdapter(adapterClientes);

        //Evento de Click

        recyclerView.addOnItemTouchListener(
                new RecyclerItemClickListener(
                        getApplicationContext(),
                        recyclerView,
                        new RecyclerItemClickListener.OnItemClickListener() {
                            @Override
                            public void onItemClick(View view, int position) {
                                Cliente cliente = listaClientes.get(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Cliente Selecionado: " + cliente.getNomeCliente(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onLongItemClick(View view, int position) {
                                Cliente cliente = listaClientes.get(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Cliente Selecionado: " + cliente.getNomeCliente(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                            }
                        }

                )
        );


        // Buttons
        addCliente = findViewById(R.id.btnAddCliente);
        editarCliente = findViewById(R.id.btnEditarProduto);
        apagarCliente = findViewById(R.id.btnApagarProduto);
        txtClientes = findViewById(R.id.textViewCliente);

    }

    // Metodos dos Buttons
    public void CadastrarCliente(View view){
        startActivity(new Intent(this,CadastrarClienteActivity.class));
    }

    public void EditarCliente(View view){

    }

    public void DeletarCliente(View view){

    }



    public void listarClientes(){

        Cliente cliente = new Cliente("0" ,"rafael","rafaellopes.01@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("1","paulo Viadooo","teste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("2","teste","teste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("3","jao","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("4","tiao","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("5","Diego gay","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("6","Marcus Viado","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("7","afa","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("8","dgdagds","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("9","agddag","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("10","aggsd","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

        cliente = new Cliente("11","sdsdg","tffeste@hotmail.com");
        this.listaClientes.add(cliente);

    }


}
