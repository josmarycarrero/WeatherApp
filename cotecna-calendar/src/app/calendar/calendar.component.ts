import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import * as moment from 'moment';

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.scss']
})
export class CalendarComponent implements OnChanges {

  @Input() month:number;
  @Input() year:number;

  readonly dayNames = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
  calendarMonth: any[]; // TO DO Create calendar day model

  private currentDay = moment()
    .startOf('day');
  private weatherDays = Array(5)
    .fill(0)
    .map((n, i) => this.currentDay
      .clone()
      .add(n + i, 'day')
      .toDate()
      .getTime()
    );

  ngOnChanges(changes: SimpleChanges) {
    if (changes.month || changes.year) {
      this.getCalendarMonth();
    }
  }

  getCalendarMonth() {
    const startWeek = moment().month(this.month).year(this.year).startOf('month').week();
    const endWeek = moment().month(this.month).year(this.year).endOf('month').week();
    
    let calendar = [];
    for (var week = startWeek; week <= endWeek; week++) {
      const days = Array(7)
        .fill(0)
        .map((n, i) => {
          const day = moment().week(week).startOf('week').clone().add(n + i, 'day');
          return {
            date: day.date(),
            today: this.isToday(day),
            weather: this.getWeather(day)
          }
        });
      calendar = [...calendar, ...days];
    }
    this.calendarMonth = calendar;
  }

  private isToday(day: moment.Moment) {
    return this.currentDay.toDate().getTime() === day.toDate().getTime();
  }

  private getWeather(day: moment.Moment) {
    return this.weatherDays.includes(day.toDate().getTime())
      ? 'lorem ipsum' // Get weather from webService
      : undefined;
  }

}
