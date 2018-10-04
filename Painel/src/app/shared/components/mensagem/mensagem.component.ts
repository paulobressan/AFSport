import { Component, Input } from "@angular/core";

@Component({
    selector: 'af-mensagem',
    templateUrl: './mensagem.component.html'
})
export class MensagemComponent {
    @Input() texto;
}