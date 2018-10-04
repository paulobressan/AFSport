import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';
import { RouterModule } from '@angular/router';
import { TokenService } from './token/token.service';
import { AuthService } from './auth/auth.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
    declarations: [
        HeaderComponent
    ],
    imports: [
        CommonModule,
        RouterModule,
        HttpClientModule
    ],
    exports: [
        HeaderComponent
    ],
    providers:[
        TokenService,
        AuthService
    ]
})
export class CoreModule { }