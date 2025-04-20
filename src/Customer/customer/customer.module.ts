import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateCustomerComponent } from '../CreateCustomer/create-customer/create-customer.component';
import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CustomerRoutingModule } from './customer-routing.module';
import { AppModule } from '../../app/app.module';
import { SharedModule } from '../../shared.module';



@NgModule({
  declarations: [
    CreateCustomerComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule  // used for Forms , formGroup , FormBuilder
    ,CustomerRoutingModule
    ,SharedModule
   
  ],
  exports:[
    CreateCustomerComponent
  ]
})
export class CustomerModule { }
