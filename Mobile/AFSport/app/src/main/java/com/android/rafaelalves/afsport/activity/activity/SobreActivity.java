package com.android.rafaelalves.afsport.activity.activity;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

import com.android.rafaelalves.afsport.R;

import mehdi.sakout.aboutpage.AboutPage;

public class SobreActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.activity_sobre);

        //String descricao = "";

        View sobre = new AboutPage(this)
                .isRTL(false)
                //.setImage(R.drawable.logo)
                //.setDescription(descricao)
                .addGroup("Fale conosco")
                .addEmail("suporte@afsport.com.br","Contate-nos")
                .addWebsite("unip.br","Acesse Nosso Site")
                .addGroup("Acesse Nossas Redes Sociais")
                .addGitHub("paulobressan/AFSport","GitHub")
                .addFacebook("facebook","Facebook")
                .addTwitter("twitter","Twitter")
                .addInstagram("instagram","Instagram")
                .addYoutube("youtube","Youtube")
                //.addPlayStore("","")
                .create();
        setContentView(sobre);
    }
}
