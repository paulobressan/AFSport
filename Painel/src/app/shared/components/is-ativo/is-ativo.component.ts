import { Component, Input, Output, EventEmitter } from "@angular/core";

@Component({
    selector: 'af-is-ativo',
    templateUrl: './is-ativo.component.html'
})
export class IsAtivoComponent {
    @Input() isAtivo: boolean;
    @Output() onIsAtivo = new EventEmitter<boolean>();

    AtivarInativar(isAtivo: boolean) {
        this.onIsAtivo.emit(isAtivo);
    }
}