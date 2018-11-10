package com.android.rafaelalves.afsport.activity.activity;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.dao.AuthDAO;
import com.android.rafaelalves.afsport.activity.model.Auth;

public class LoginActivity extends AppCompatActivity {
    private Button btnLogin;
    private TextView editLogin;
    private TextView editSenha;
    private final AuthDAO AUTH_DAO;

    public LoginActivity( ) {
        this.AUTH_DAO = new AuthDAO();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        editLogin = findViewById(R.id.editLogin);
        editSenha = findViewById(R.id.editSenha);
        btnLogin = findViewById(R.id.btnEnviar);
    }

    public void Autenticar(View view){
        Auth auth = new Auth(editLogin.getText().toString(), editSenha.getText().toString());
        AUTH_DAO.Autenticar(auth);
    }
}
