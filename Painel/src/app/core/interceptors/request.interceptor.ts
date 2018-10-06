import { Injectable } from "@angular/core";
import { HttpRequest, HttpInterceptor, HttpHandler, HttpSentEvent, HttpHeaderResponse, HttpProgressEvent, HttpResponse, HttpUserEvent } from '@angular/common/http';
import { Observable } from "rxjs";

import { TokenService } from "../token/token.service";
import { HttpHeaders } from "@angular/common/http";
import { Router } from "@angular/router";

@Injectable()
export class RequestInterceptor implements HttpInterceptor {
    constructor(
        private tokenService: TokenService,
        private router: Router
    ) { }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpSentEvent
        | HttpHeaderResponse | HttpProgressEvent | HttpResponse<any> | HttpUserEvent<any>> {

        if (this.tokenService.hasToken()) {
            const token = this.tokenService.getToken();
            req = req.clone({
                setHeaders: {
                    'Authorization': `Bearer ${token}`
                }
            })
        }
        return next.handle(req);
    }
}