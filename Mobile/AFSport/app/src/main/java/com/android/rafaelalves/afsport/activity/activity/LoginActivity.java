package com.android.rafaelalves.afsport.activity.activity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.preference.Preference;
import android.preference.PreferenceManager;
import android.support.annotation.NonNull;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.model.Auth;
import com.android.rafaelalves.afsport.activity.web.WebClient;

import java.io.IOException;

import okhttp3.ResponseBody;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class LoginActivity extends AppCompatActivity {
    private Button btnLogin;
    private TextView editLogin;
    private TextView editSenha;
    private final WebClient webClient;
    SharedPreferences preference;

    public LoginActivity() {
        this.webClient = new WebClient();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        editLogin = findViewById(R.id.editLogin);
        editSenha = findViewById(R.id.editSenha);
        btnLogin = findViewById(R.id.btnEnviar);
        preference = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
    }

    public void Autenticar(View view) {
        Auth auth = new Auth(editLogin.getText().toString(), editSenha.getText().toString());
        webClient.getAuth(auth).enqueue(new Callback<ResponseBody>() {
            @Override
            public void onResponse(@NonNull Call<ResponseBody> call, @NonNull Response<ResponseBody> response) {
                try {
                    preference.edit().putString("KEY_AUTH", response.body().string()).commit();
                    //Pegar valor global, instanciar SHaredPreference
                    //preference.getString("KEY_AUTH", "");
                    Toast.makeText(
                            getApplicationContext(),
                            "Usuário autenticado com sucesso",
                            Toast.LENGTH_SHORT
                    ).show();
                    finish();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }

            @Override
            public void onFailure(@NonNull Call<ResponseBody> call, @NonNull Throwable t) {
                Toast.makeText(
                        getApplicationContext(),
                        "Problemas para se autenticar, tente novamente mais tarde.",
                        Toast.LENGTH_SHORT
                ).show();
            }
        });
    }
}
