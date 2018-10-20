import { AbstractControl } from '@angular/forms';

export function ValidateIdValidator(control: AbstractControl) {
    if (control.value > 0)
        return null;
    return { validateId: true }
}