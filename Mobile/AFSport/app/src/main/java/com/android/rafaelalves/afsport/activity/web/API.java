package com.android.rafaelalves.afsport.activity.web;

import com.android.rafaelalves.afsport.activity.model.Auth;
import com.android.rafaelalves.afsport.activity.model.Cliente;
import com.android.rafaelalves.afsport.activity.model.Produto;

import java.util.List;

import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.Header;
import retrofit2.http.Headers;
import retrofit2.http.POST;

public interface API {

    @Headers("Content-Type: application/json")
    @POST("auth")
    Call<ResponseBody> getAuth(@Body Auth auth);

    @Headers("Content-Type: application/json")
    @GET("cliente")
    Call<List<Cliente>> getAllClientes(@Header("Authorization") String auth);

    @Headers("Content-Type: application/json")
    @GET("produto")
    Call<List<Produto>> getAllProdutos(@Header("Authorization") String auth);

}
