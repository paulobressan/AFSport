import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { tap } from 'rxjs/operators';

import { UserService } from "../user/user.service";
import { User } from "../user/user";
import { environment } from "../../../environments/environment";


@Injectable()
export class AuthService {
    constructor(
        private http: HttpClient,
        private userService: UserService
    ) { }

    autenticate(user: User) {
        return this.http.post(environment.auth, user, {responseType: 'text'})
            .pipe(tap(token => {
                this.userService.setToken(token);
            }));
    }
}