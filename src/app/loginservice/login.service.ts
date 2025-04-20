import { Injectable, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Loginmodel } from './loginmodel';

@Injectable({
  providedIn: 'root'
})
export class LoginService  {

  loginDetails: Loginmodel = new Loginmodel();

  constructor() {
    try {
      this.loginDetails.LastName = 'Jena';
      this.loginDetails.firstName = 'Cena';
      this.loginDetails.email = '123@gmail.com';
      this.loginDetails.loginId = '1';
      this.loginDetails.loginInTime = new Date();
    } catch (error) {
      console.error('Error initializing loginDetails', error);
    }
  }




}
