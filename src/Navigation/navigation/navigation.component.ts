import { Component } from '@angular/core';

@Component({
  selector: 'app-navigation',
  standalone: false,
  templateUrl: './navigation.component.html',
  styleUrl: './navigation.component.scss'
})
export class NavigationComponent {

  isCollapsed = false;

  toggleSidebar() {
    this.isCollapsed = !this.isCollapsed;
  }
}
