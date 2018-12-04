import { Component } from '@angular/core';

@Component({
    templateUrl: './home.component.html'
})
export class HomeComponent {
    pieChartData = {
        chartType: 'PieChart',
        dataTable: [
            ['Task', 'Hours per Day'],
            ['Work', 11],
            ['Eat', 2],
            ['Commute', 2],
            ['Watch TV', 2],
            ['Sleep', 7]
        ],
        options: { 'title': 'Tasks' },
    };

    columnChart = {
        chartType: 'ColumnChart',
        dataTable: [
            ['Element', 'Density', { role: 'style' }],  
            ['Copper', 8.94, '#b87333'],     
            ['Silver', 10.49, 'silver'],     
            ['Gold', 19.30, 'gold'],
            ['Platinum', 21.45, 'color: #e5e4e2'],
        ]
    }
}