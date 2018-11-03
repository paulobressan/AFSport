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
import com.android.rafaelalves.afsport.activity.adapter.AdapterProdutos;
import com.android.rafaelalves.afsport.activity.model.Produto;

import java.util.ArrayList;
import java.util.List;

public class ProdutosActivity extends AppCompatActivity {

    private RecyclerView recyclerView;
    private List<Produto> listaProdutos = new ArrayList<>();


    private Button addProduto;
    private Button editarProduto;
    private Button apagarProduto;
    private TextView txtProduto;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_produtos);

        recyclerView = findViewById(R.id.recyclerProduto);

        // Criar Lista de Produtos

        this.listarProdutos();

        // Configurar Adapter
        AdapterProdutos adapterProdutos = new AdapterProdutos(listaProdutos);

        //Configurar RecyclerView

        RecyclerView.LayoutManager layoutManager = new LinearLayoutManager(getApplicationContext());
        recyclerView.setLayoutManager(layoutManager);
        recyclerView.setHasFixedSize(true);
        recyclerView.addItemDecoration(new DividerItemDecoration(this, LinearLayout.VERTICAL));
        recyclerView.setAdapter(adapterProdutos);

        //Evento de Click

        recyclerView.addOnItemTouchListener(
                new RecyclerItemClickListener(
                        getApplicationContext(),
                        recyclerView,
                        new RecyclerItemClickListener.OnItemClickListener() {
                            @Override
                            public void onItemClick(View view, int position) {
                                Produto produto = listaProdutos.get(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Item Selecionado: " + produto.getNomeProduto(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onLongItemClick(View view, int position) {
                                Produto produto = listaProdutos.get(position);
                                Toast.makeText(
                                        getApplicationContext(),
                                        "Item Selecionado: " + produto.getNomeProduto(),
                                        Toast.LENGTH_SHORT
                                ).show();
                            }

                            @Override
                            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                            }
                        }

                )
        );


        //Buttons

        addProduto = findViewById(R.id.btnAddProduto);
        editarProduto = findViewById(R.id.btnEditarProduto);
        apagarProduto = findViewById(R.id.btnApagarProduto);




    }

    // Metodos dos Buttons
    public void CadastrarProduto(View view){
        startActivity(new Intent(this,CadastrarProdutoActivity.class));
    }

    public void EditarProduto(View view){

    }

    public void DeletarProduto(View view){

    }


    public void listarProdutos(){
        Produto produto = new Produto("0","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("1","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("2","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("3","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("4","Chuteira Nike Futsal", "Vermelha - tamanho 58 - Conforto e qualidade fei", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("5","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("6","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("7","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("8","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("9","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("10","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

        produto = new Produto("11","Chuteira", "Vermelha", "R$ 250,00");
        listaProdutos.add(produto);

    }
}
