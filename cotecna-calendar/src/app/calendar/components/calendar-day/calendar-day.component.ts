import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-calendar-day',
  templateUrl: './calendar-day.component.html',
  styleUrls: ['./calendar-day.component.scss']
})
export class CalendarDayComponent {

  @Input() date:number; 
  @Input() today:boolean;
  @Input() weather: any; // TO DO create the weather object

}
