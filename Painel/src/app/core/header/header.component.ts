import { Component, OnInit, AfterViewChecked, AfterContentInit, AfterViewInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../user/user';
import { UserService } from '../user/user.service';
import { Router } from '@angular/router';

declare var $;

@Component({
    selector: 'af-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
    user$: Observable<User>;

    constructor(
        private userService: UserService,
        private router: Router
    ) { }

    ngOnInit(): void {
        this.user$ = this.userService.getUser();
    }

    toggle() {
        $('#sidebar').toggleClass('active');
    }

    isLogged() {
        return this.userService.isLogged();
    }

    logout() {
        this.userService.logout();
        this.router.navigate(['login']);
    }
}