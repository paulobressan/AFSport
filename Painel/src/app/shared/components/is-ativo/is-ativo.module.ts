import { NgModule } from "@angular/core";
import { IsAtivoComponent } from "./is-ativo.component";
import { CommonModule } from "@angular/common";

@NgModule({
    declarations: [IsAtivoComponent],
    imports: [
        CommonModule
    ],
    exports: [IsAtivoComponent]
})
export class IsAtivoModule { }