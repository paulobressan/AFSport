import { Component, OnInit, AfterViewChecked, AfterContentInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../user/user';
import { UserService } from '../user/user.service';

declare var $;

@Component({
    selector: 'af-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit, AfterContentInit {
    user$: Observable<User>;

    constructor(private userService: UserService) { }

    ngOnInit(): void {
        this.user$ = this.userService.getUser();
    }

    ngAfterContentInit(): void {
        $('#sidebarCollapse').on('click', function () {
            $('#sidebar').toggleClass('active');
        });
    }

    isLogged(){
        return this.userService.isLogged();
    }
}