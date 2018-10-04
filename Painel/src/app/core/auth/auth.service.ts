import { HttpClient, HttpHeaders } from "@angular/common/http";
import { tap } from 'rxjs/operators';
import { Injectable } from "@angular/core";

import { UserService } from "../user/user.service";
import { User } from "../user/user";

const URI = "http://localhost:4000/api";

@Injectable()
export class AuthService {
    constructor(
        private http: HttpClient,
        private userService: UserService
    ) { }

    autenticate(user: User) {
        var headers = new HttpHeaders();
        headers.set("content-type", "application/json");
        return this.http.post(`${URI}/auth`, user, { headers })
            .pipe(tap(token => {
                this.userService.setToken(token.toString());
                console.log(token);
            }))
    }
}