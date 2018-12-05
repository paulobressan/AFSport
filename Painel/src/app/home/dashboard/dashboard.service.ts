import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Dashboard } from './dashboard';

const URL = environment.dashboard;

@Injectable()
export class DashboardService {
    constructor(private http: HttpClient) { }

    getGraficoMovimentacaoMensal(): Observable<Dashboard[]> {
        return this.http.get<Dashboard[]>(`${URL}/grafico-movimentacao-mensal`);
    }
}