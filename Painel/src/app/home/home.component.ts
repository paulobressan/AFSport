import { Component, OnInit } from '@angular/core';
import { DashboardService } from './dashboard/dashboard.service';

@Component({
    templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
    constructor(private dashboardService: DashboardService) { }
    graficoMovimentacao: any[] = [];

    ngOnInit(): void {
        this.dashboardService.getGraficoMovimentacaoMensal()
            .subscribe(dashboards => {
                this.graficoMovimentacao.push(['Element', 'Movimentações', { role: 'style' }]);
                for (let dashboard of dashboards) {
                    this.graficoMovimentacao.push([dashboard.data, dashboard.valor, 'style']);
                }
            });
    }

    columnChart = {
        chartType: 'ColumnChart',
        dataTable: this.graficoMovimentacao
    }
}