import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

import { User } from "../core/user/user";
import { AuthService } from "../core/auth/auth.service";
import { Router } from "@angular/router";

@Component({
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
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
    }

    autenticar() {
        const user: User = this.loginForm.getRawValue();
        this.authService.autenticate(user).subscribe(() => {
            this.router.navigate(['']);
        });
    }
}