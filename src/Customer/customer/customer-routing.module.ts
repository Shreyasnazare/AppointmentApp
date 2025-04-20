import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { CreateCustomerComponent } from '../CreateCustomer/create-customer/create-customer.component';

const routes: Routes = [
  {
    path: '',
    component: CreateCustomerComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRoutingModule { }
