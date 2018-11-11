package com.android.rafaelalves.afsport.activity.activity;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import com.android.rafaelalves.afsport.R;
import com.github.mikephil.charting.charts.PieChart;
import com.github.mikephil.charting.data.PieData;
import com.github.mikephil.charting.data.PieDataSet;
import com.github.mikephil.charting.data.PieEntry;
import com.github.mikephil.charting.utils.ColorTemplate;

import java.util.ArrayList;
import java.util.List;

public class CaixaActivity extends AppCompatActivity {

    /* Array float, será responsável por definir a porcentagem de cada item do nosso gráfico*/
    float itensGrafico[] = {98.6f, 56.8f, 35.6f, 45.7f, 10.5f};
    /* Array string, será responsável por definir o nome  de cada item do nosso gráfico*/
    String descricao[] = {"Vinicius Gay 45%", "Rafa Gay 19%", "Diego gay 0%"};

    /*Grafico*/
    PieChart grafico;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_caixa);

        PieChart grafico = (PieChart) findViewById(R.id.graficoID);

        /*Lista criada do tipo <PieChart>*/
        List<PieEntry> entradasGrafico = new ArrayList<>();
        /*Preenchendo o grafco*/

        for(int i = 0; i < itensGrafico.length; i++){
            entradasGrafico.add(new PieEntry(itensGrafico[i], descricao[i]));


        }
        PieDataSet dataSet = new PieDataSet(entradasGrafico, ("Descrição do Grafico"));
        dataSet.setColors(ColorTemplate.COLORFUL_COLORS);

        PieData pieData = new PieData(dataSet);

        grafico.setData(pieData);
        grafico.invalidate();


    }
}
