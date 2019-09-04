import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'cotecna-calendar';
  month: number = new Date().getMonth();
  year: number = new Date().getFullYear();

  months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
  years = Array(10).fill(0).map((v,i)=>new Date().getFullYear()+i);
}
