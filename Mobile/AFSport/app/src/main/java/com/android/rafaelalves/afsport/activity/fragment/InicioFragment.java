package com.android.rafaelalves.afsport.activity.fragment;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.android.rafaelalves.afsport.R;

/**
 * A simple {@link Fragment} subclass.
 */
public class InicioFragment extends Fragment {

    private TextView textInicio;

    public InicioFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_inicio, container, false);

        textInicio = view.findViewById(R.id.textInicio);

        return view;
    }

}
