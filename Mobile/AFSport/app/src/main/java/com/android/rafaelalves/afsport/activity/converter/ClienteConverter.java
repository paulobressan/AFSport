package com.android.rafaelalves.afsport.activity.converter;

import com.android.rafaelalves.afsport.activity.model.Cliente;

import org.json.JSONException;
import org.json.JSONStringer;

import java.util.List;

public class ClienteConverter {
    public String converteParaJSON(List<Cliente> clientes) {
        JSONStringer js = new JSONStringer();

        try {
            js.object().key("list").array().object().key("cliente").array();
            for (Cliente cliente : clientes) {
                js.object();
                js.key("idCliente").value(cliente.getIdCliente());
                js.key("nome").value(cliente.getNome());
                js.key("email").value(cliente.getEmail());
                js.key("isAtivo").value(cliente.getAtivo());
                js.key("logradouro").value(cliente.getLogradouro());
                js.key("bairro").value(cliente.getBairro());
                js.key("numero").value(cliente.getNumero());
                js.key("idCidade").value(cliente.getIdCidade());

                js.endObject();
            }
            js.endArray().endObject().endArray().endObject();
        } catch (JSONException e) {
            e.printStackTrace();
        }

        return js.toString();
    }
}
