import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

import { LoginComponent } from "./login.component";
import { MensagemModule } from "../shared/components/mensagem/mensagem.module";
import { AuthService } from "../core/auth/auth.service";

@NgModule({
    declarations: [LoginComponent],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        MensagemModule
    ],
    exports: [LoginComponent],
    providers: [AuthService]
})
export class LoginModule { }