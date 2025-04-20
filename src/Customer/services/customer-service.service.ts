import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';
import { ConfigService } from '../../assets/config.service';

@Injectable({
  providedIn: 'root'
})
export class CustomerServiceService {

  baseurl: string = '';
  constructor(private httpclient: HttpClient
    , private configservice: ConfigService
  ) {
    this.baseurl = this.configservice.apiBaseUrl;


  }

  async getCustomerDetails(email: any): Promise<any> {
   
    const apiUrl = `${this.baseurl}/Customer/GetCustomerByEmail/${email}`;
    try {
      const response: any = await firstValueFrom(this.httpclient.get(apiUrl));
      return response.Data;
    } catch (error) {
      console.error('Error fetching user:', error);
      throw error;
    }
  }

  async updateCustomerDetails(request: any): Promise<any> {
    
    const apiUrl = `${this.baseurl}/Customer/UpdateCustomer`;
    try {
      const response: any = await firstValueFrom(this.httpclient.post(apiUrl,request));
      return response.Data;
    } catch (error) {
      console.error('Error fetching user:', error);
      throw error;
    }
  }


}
