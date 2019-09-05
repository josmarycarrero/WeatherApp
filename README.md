## Calendar Excercice ##


As Cotecna inspector I need a new calendar app that allows me to see the weather forecast for the next 5 days so that I’m able to plan my inspections accordingly.

The calendar should have two dropdowns to allow me to select a year and a month and it will display all the days of the selected month in a row-per-week view (just like the windows calendar).

Additionally, the calendar should be able to display the temperature and weather condition forecast for the next 5 days (only when the calendar is set to the current month).


**Solution**


- **WeatherAPI** : .Net Core 2.1 project API, connects to Openweathermap API service and gets forecast5 information.

- **WeatherAPI.Test**: Unit test for Weather API using Xunit.

- **cotecna-calendar**: Angular 7 application that displays a monthly calendar, with 2 dropdowns for year and month selection. If current month shows next five days forecast, getting the forecast form WeatherAPI
