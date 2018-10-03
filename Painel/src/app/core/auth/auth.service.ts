import { HttpClient } from "@angular/common/http";
import { tap } from 'rxjs/operators';

import { UserService } from "../user/user.service";
import { User } from "../user/user";

const URI = "http://localhost:4000/api";

export class AuthService {
    constructor(
        private http: HttpClient,
        private userService: UserService
    ) { }

    autenticate(user: User) {
        return this.http.post(`${URI}/auth`, user)
            .pipe(tap(token => {
                this.userService.setToken(token.toString());
                console.log(token); 
            }))
    }
}