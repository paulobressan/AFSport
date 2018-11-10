package com.android.rafaelalves.afsport.activity.converter;

import com.android.rafaelalves.afsport.activity.model.Auth;

import org.json.JSONException;
import org.json.JSONStringer;

import java.util.List;

public class AuthConverter {
    public String converteParaJSON(Auth auth) {
        JSONStringer js = new JSONStringer();

        try {
            js.object().key("list").array().object().key("auth").array();
            js.object();
            js.key("login").value(auth.getLogin());
            js.key("senha").value(auth.getSenha());
            js.endObject();
            js.endArray().endObject().endArray().endObject();
        } catch (JSONException e) {
            e.printStackTrace();
        }

        return js.toString();
    }
}