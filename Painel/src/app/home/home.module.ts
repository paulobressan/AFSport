import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeComponent } from './home.component';
import { HomeRoutingModule } from './home.routing.module';
import { Ng2GoogleChartsModule } from 'ng2-google-charts';
@NgModule({
    declarations: [HomeComponent],
    exports: [HomeComponent],
    imports: [
        CommonModule,
        HomeRoutingModule,
        Ng2GoogleChartsModule
    ]
})
export class HomeModule { }