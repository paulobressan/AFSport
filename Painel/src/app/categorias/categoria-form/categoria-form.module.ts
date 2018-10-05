import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

import { CategoriaFormComponent } from "./categoria-form.component";
import { MensagemModule } from "../../shared/components/mensagem/mensagem.module";

@NgModule({
    declarations: [CategoriaFormComponent],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule,
        MensagemModule
    ]
})
export class CategoriaFormModule { }