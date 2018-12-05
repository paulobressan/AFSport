package com.android.rafaelalves.afsport.activity.fragment;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.android.rafaelalves.afsport.R;
import com.github.mikephil.charting.charts.BarChart;
import com.github.mikephil.charting.charts.PieChart;
import com.github.mikephil.charting.data.BarData;
import com.github.mikephil.charting.data.BarDataSet;
import com.github.mikephil.charting.data.BarEntry;
import com.github.mikephil.charting.data.PieData;
import com.github.mikephil.charting.data.PieDataSet;
import com.github.mikephil.charting.data.PieEntry;
import com.github.mikephil.charting.utils.ColorTemplate;

import java.util.ArrayList;
import java.util.List;

/**
 * A simple {@link Fragment} subclass.
 */
public class InicioFragment extends Fragment {

    private TextView textInicio;

    /* Array float, será responsável por definir a porcentagem de cada item do nosso gráfico*/
    float itensGrafico[] = {98.6f, 56.8f, 35.6f, 45.7f, 10.5f};
    /* Array string, será responsável por definir o nome  de cada item do nosso gráfico*/
    String descricao[] = {"1", "2", "3","4","5"};

    /*Grafico*/
    BarChart grafico;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_inicio, container, false);

        

        grafico = (BarChart) view.findViewById(R.id.graficoID);

        /*Lista criada do tipo <PieChart>*/
        List<BarEntry> entradasGrafico = new ArrayList<>();
        /*Preenchendo o grafco*/

        for (int i = 0; i < itensGrafico.length; i++) {
            entradasGrafico.add(new BarEntry(itensGrafico[i], i));
        }
        BarDataSet dataSet = new BarDataSet(entradasGrafico, ("Descrição do Grafico"));
        dataSet.setColors(ColorTemplate.COLORFUL_COLORS);

        BarData pieData = new BarData(dataSet);

        grafico.setData(pieData);
        grafico.invalidate();

        return view;
    }

}
