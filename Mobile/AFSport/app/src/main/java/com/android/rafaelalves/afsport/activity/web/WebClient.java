package com.android.rafaelalves.afsport.activity.web;


import com.android.rafaelalves.afsport.activity.model.Auth;
import com.android.rafaelalves.afsport.activity.model.Caixa;
import com.android.rafaelalves.afsport.activity.model.Cliente;
import com.android.rafaelalves.afsport.activity.model.Pedido;
import com.android.rafaelalves.afsport.activity.model.Produto;

import java.util.List;

import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class WebClient {

    private final String url = "https://5f03b7dc.ngrok.io/api/";
    private Retrofit retrofit;

    public Call<ResponseBody> getAuth(Auth auth) {
        return getRetrofit().create(API.class).getAuth(auth);
    }

    public Call<List<Cliente>> getAllClientes(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllClientes(token);
    }

    public Call<List<Cliente>> getAllClientesAtivos(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllClientesAtivos(token);
    }

    public Call<List<Produto>> getAllProdutos(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllProdutos(token);
    }

    public Call<List<Produto>> getAllProdutosAtivos(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllProdutosAtivos(token);
    }

    public Call<List<Caixa>> getAllCaixas(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllCaixas(token);
    }

    public Call<List<Pedido>> getAllPedidos(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllPedidos(token);
    }

    public Call<Pedido> postPedido(String keyAuth, Pedido pedido) {
        return getRetrofit().create(API.class).postPedido(keyAuth, pedido);
    }

    public Call<Pedido> postItemPedido(String keyAuth, Pedido pedido) {
        return getRetrofit().create(API.class).postItemPedido(keyAuth, pedido);
    }

    private Retrofit getRetrofit() {
        if (retrofit == null)
            retrofit = new Retrofit.Builder()
                    .baseUrl(url)
                    .addConverterFactory(GsonConverterFactory.create())
                    .build();
        return retrofit;
    }
}
