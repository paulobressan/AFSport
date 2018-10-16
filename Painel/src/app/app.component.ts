import { Component, OnDestroy } from '@angular/core';
import { UserService } from './core/user/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnDestroy {

  constructor(private userService: UserService) { }

  ngOnDestroy(): void {
    if (this.userService.isLogged())
      this.userService.logout();
  }
}
