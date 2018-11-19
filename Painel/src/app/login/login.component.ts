import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import swal from 'sweetalert';

import { User } from "../core/user/user";
import { AuthService } from "../core/auth/auth.service";
import { Router } from "@angular/router";
import { ViewChild } from "@angular/core";
import { ElementRef } from "@angular/core";

@Component({
    templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {
    @ViewChild('loginInput') loginInput: ElementRef<HTMLInputElement>;
    @ViewChild('loadButton') loadButton: ElementRef<HTMLImageElement>;
    loginForm: FormGroup;

    constructor(
        private formBuilder: FormBuilder,
        private authService: AuthService,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.loginForm = this.formBuilder.group({
            login: ['', [Validators.required, Validators.maxLength(30)]],
            senha: ['', [Validators.required, Validators.maxLength(30)]]
        });
        this.loginInput.nativeElement.focus();
    }

    autenticar() {
        this.loadButton.nativeElement.style.display = 'inline-block';
        const user: User = this.loginForm.getRawValue();
        this.authService.autenticate(user)
            .subscribe(() => {
                this.router.navigate(['']);
            }, err => {
                this.loadButton.nativeElement.style.display = 'none';
                swal("Problemas para enviar!", JSON.parse(err.error).msg, "error");
            });
    }
}