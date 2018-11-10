package com.android.rafaelalves.afsport.activity.dao;

import com.android.rafaelalves.afsport.activity.converter.AuthConverter;
import com.android.rafaelalves.afsport.activity.model.Auth;
import com.android.rafaelalves.afsport.activity.web.WebClient;

public class AuthDAO {
    private final WebClient webClient;
    private final AuthConverter authConverter;

    public AuthDAO() {
        this.webClient = new WebClient("auth");
        this.authConverter = new AuthConverter();
    }

    public String Autenticar(Auth auth){
        String authJson = authConverter.converteParaJSON(auth);
        String token = webClient.post(authJson);
        return token;
    }
}
