package com.android.rafaelalves.afsport.activity.web;


import com.android.rafaelalves.afsport.activity.model.Auth;
import com.android.rafaelalves.afsport.activity.model.Cliente;
import com.android.rafaelalves.afsport.activity.model.Produto;

import java.util.List;

import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class WebClient {

    private final String url = "https://9ba7d472.ngrok.io/api/";
    private Retrofit retrofit;

    public Call<ResponseBody> getAuth(Auth auth) {
        return getRetrofit().create(API.class).getAuth(auth);
    }

    public Call<List<Cliente>> getAllClientes(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllClientes(token);
    }

    public Call<List<Produto>> getAllProdutos(String keyAuth){
        String token = "Bearer " + keyAuth;
        return getRetrofit().create(API.class).getAllProdutos(token);
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
