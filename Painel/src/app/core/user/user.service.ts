import { Injectable } from "@angular/core";
import * as jwt_token from 'jwt-decode';
import { BehaviorSubject, Observable } from "rxjs";

import { TokenService } from "../token/token.service";
import { User } from "./user";

@Injectable()
export class UserService {
    private userSubject = new BehaviorSubject<User>(null);

    constructor(
        private tokenService: TokenService
    ) { }

    getUser(): Observable<User> {
        return this.userSubject.asObservable()
    }

    setToken(token: string): void {
        this.tokenService.setToken(token);
    }

    private decodeTokenAndNotify(): void {
        const token = this.tokenService.getToken();
        const user: User = jwt_token(token) as User;
        this.userSubject.next(user);
    }

    logout() {
        this.tokenService.removeToken();
        this.userSubject.next(null);
    }

    isLogged() {
        return this.tokenService.hasToken();
    }
}