import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

import { CategoriaFormComponent } from "./categoria-form.component";
import { MensagemModule } from "../../shared/components/mensagem/mensagem.module";
import { RouterModule } from "@angular/router";

@NgModule({
    declarations: [CategoriaFormComponent],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        MensagemModule,
        RouterModule
    ]
})
export class CategoriaFormModule { }