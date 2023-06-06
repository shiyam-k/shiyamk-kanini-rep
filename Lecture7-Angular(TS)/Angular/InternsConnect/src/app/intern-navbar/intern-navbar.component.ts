import { Component } from '@angular/core';

@Component({
  selector: 'app-intern-navbar',
  templateUrl: './intern-navbar.component.html',
  styleUrls: ['./intern-navbar.component.css']
})
export class InternNavbarComponent {
  isNavbarOpen: boolean = false;

  toggleNavbar(): void {
    this.isNavbarOpen = !this.isNavbarOpen;
  }
}
