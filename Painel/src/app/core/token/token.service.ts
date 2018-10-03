import { Injectable } from "@angular/core";

const KEY = 'authToken';

@Injectable()
export class TokenService {
    hasToken(): boolean {
        return !!this.getToken();
    }

    getToken(): string {
        return window.localStorage.getItem(KEY);
    }

    setToken(token: string) {
        window.localStorage.setItem(KEY, token);
    }

    removeToken() {
        window.localStorage.removeItem(KEY);
    }
}