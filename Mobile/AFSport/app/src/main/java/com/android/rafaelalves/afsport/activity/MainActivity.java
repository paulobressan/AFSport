package com.android.rafaelalves.afsport.activity;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v4.app.FragmentTransaction;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;


import com.android.rafaelalves.afsport.R;
import com.android.rafaelalves.afsport.activity.fragment.CaixaFragment;
import com.android.rafaelalves.afsport.activity.fragment.ClientesFragment;
import com.android.rafaelalves.afsport.activity.fragment.EstoqueFragment;
import com.android.rafaelalves.afsport.activity.fragment.InicioFragment;
import com.android.rafaelalves.afsport.activity.fragment.MovimentacoesFragment;
import com.android.rafaelalves.afsport.activity.fragment.ProdutosFragment;
import com.android.rafaelalves.afsport.activity.fragment.SobreFragment;

public class MainActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

       /* InicioFragment inicioFragment = new InicioFragment();
        FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
        fragmentTransaction.replace(R.id.frameContainer,inicioFragment);
        fragmentTransaction.commit();
        */
        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.addDrawerListener(toggle);
        toggle.syncState();

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);
    }

    @Override
    public void onBackPressed() {
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

        if (id == R.id.nav_inicio) {
            InicioFragment inicioFragment = new InicioFragment();
            FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
            FragmentTransaction.replace(R.id.frameContainer, inicioFragment);
            fragmentTransaction.commit();

        } else if (id == R.id.nav_clientes) {
            ClientesFragment clientesFragment = new ClientesFragment();
            FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
            FragmentTransaction.replace(R.id.frameContainer, clientesFragment);
            fragmentTransaction.commit();

        } else if (id == R.id.nav_produtos) {
            ProdutosFragment produtosFragment = new ProdutosFragment();
            FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
            FragmentTransaction.replace(R.id.frameContainer, produtosFragment);
            FragmentTransaction.commit();

        } else if (id == R.id.nav_estoque) {
            EstoqueFragment estoqueFragment = new EstoqueFragment();
            FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
            FragmentTransaction.replace(R.id.frameContainer, estoqueFragment);
            FragmentTransaction.commit();

        } else if (id == R.id.nav_caixa) {
            CaixaFragment caixaFragment = new CaixaFragment();
            FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
            FragmentTransaction.replace(R.id.frameContainer, caixaFragment);
            FragmentTransaction.commit();

        } else if (id == R.id.nav_movimentacoes) {
            MovimentacoesFragment movimentacoesFragment = new MovimentacoesFragment();
            FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
            FragmentTransaction.replace(R.id.frameContainer, movimentacoesFragment);
            FragmentTransaction.commit();

        }else if (id == R.id.nav_sobre){
            SobreFragment sobreFragment = new SobreFragment();
            FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
            FragmentTransaction.replace(R.id.frameContainer, sobreFragment);
            sobreFragment.commit();
        }

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }
}
