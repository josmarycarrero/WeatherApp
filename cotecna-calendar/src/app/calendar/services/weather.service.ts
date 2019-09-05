import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {

  apiUrl = `${environment.apiUrl}/weather/`;

  constructor(
    private httpClient: HttpClient,
  ) { }

  getWeather(): Observable<any> {
    return this.httpClient.get(`${this.apiUrl}getFiveDaysWeather?cityName=Barcelona`);
  }
}
