import { Component } from '@angular/core';
import { Observable } from 'rxjs';

import { User } from './core/user/user';
import { UserService } from './core/user/user.service';
import { OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private userService: UserService) {
  }

  isLogged(){
    return this.userService.isLogged();
  }
}
