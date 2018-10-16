package com.android.rafaelalves.afsport.activity.fragment;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.android.rafaelalves.afsport.R;

import java.text.DecimalFormat;

/**
 * A simple {@link Fragment} subclass.
 */
public class CaixaFragment extends Fragment {

    private Button bt1;
    private EditText tbx1;
    private EditText tbx2;
    private TextView txtView1;
    private TextView txtView2;

    public CaixaFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {



        return inflater.inflate(R.layout.fragment_caixa, container, false);
    }

}
