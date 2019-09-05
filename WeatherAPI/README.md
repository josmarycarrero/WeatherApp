## Weather API ##


 .Net Core project API that connects to Openweathermap API service and gets forecast for the next five days.
 
 **Service Call Examples**
 
 Parameters
 
 - CityName is Mandatory
 https://localhost:5001/api/weather/getFiveDaysWeather?cityName=Barcelona
 
 - Unit is optional, by Default get standard units, accepts only metric or imperial units.
 https://localhost:5001/api/weather/getFiveDaysWeather?cityName=Barcelona&unit=metric
 https://localhost:5001/api/weather/getFiveDaysWeather?cityName=Barcelona&unit=imperial
 
 - Language is optional, by Default get english lagunage, other languages that accepts : ca (catalan) ans es(spanish).
 https://localhost:5001/api/weather/getFiveDaysWeather?cityName=Barcelona&unit=metric&language=en
 https://localhost:5001/api/weather/getFiveDaysWeather?cityName=Barcelona&unit=metric&language=ca
 https://localhost:5001/api/weather/getFiveDaysWeather?cityName=Barcelona&unit=metric&language=es


*Response Example*
 ![Application screen](https://github.com/josmarycarrero/WeatherApp/blob/master/screenshots/apiresult.PNG)
 
*How to Run API*
 Go to the WeatherAPI project folder on cmd and excute this command : dotnet run
 ![Application screen](https://github.com/josmarycarrero/WeatherApp/blob/master/screenshots/runApi.PNG)
 
 *How to Run API tests*
  Includes Unit test for Weather API using Xunit.
  Go to the WeatherAPI.Test project folder on cmd and excute this command : dotnet test
  ![Application screen](https://github.com/josmarycarrero/WeatherApp/blob/master/screenshots/test.PNG)
  
  
  





