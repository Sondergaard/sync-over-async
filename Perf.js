import { check } from 'k6';
import http from 'k6/http';

export let options = {
   vus: 100,
   iterations: 600,
 };

 export default function () {
   let params = {
     headers: {
       "Accept": "application/json",
       'Content-Type': 'application/json'
     },
     timeout: 120*1000
   };

   let theGood = http.get(`http://localhost:8080/WeatherForecast`, params);

   check(theGood, {
     'status is 200': (r) => r.status === 200
   });
 }