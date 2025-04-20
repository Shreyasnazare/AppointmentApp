import { Component,OnChanges,OnInit, SimpleChanges } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CustomerModel } from '../customermodel/customermodel';
import { CustomerServiceService } from '../../services/customer-service.service';
import { LoginService } from '../../../app/loginservice/login.service';

@Component({
  selector: 'app-create-customer',
  standalone: false,
  templateUrl: './create-customer.component.html',
  styleUrl: './create-customer.component.scss'
})
export class CreateCustomerComponent  implements OnInit, OnChanges  {


  customerForm!: FormGroup;

  constructor(private fb: FormBuilder , private customerservice : CustomerServiceService
  ,private loginservice : LoginService
  ) {
    this.customerForm = this.fb.group({
      FirstName: ['', Validators.required],
      LastName: ['', Validators.required],
      Email: ['', [Validators.required, Validators.email]],
      Address: ['', Validators.required],
      DOB: ['', Validators.required],
      Contact: ['', Validators.required],
    });
  }

 mode : string = "update";
 customer : CustomerModel = new CustomerModel();


 async ngOnInit() {
   try {
    this.customerForm.get('Email')?.disable();
   await  this.getCustomerDetails();
   } catch (error) {
    
   }  
 }
 
async getCustomerDetails(){
try {
  debugger;
  let email = this.loginservice.loginDetails.email;
  this.customer = await this.customerservice.getCustomerDetails(email);
  this.bindData() // used this as while using Form we can't use the ngModel with formControlName
 
} catch (error) {
  console.error(error)
}
}

disablefields()
{
  try {
    this.customerForm.disable();

  } catch (error) {
     console.error(error)
  }
}
bindData()
{
  try {
    this.customerForm.patchValue({
      FirstName: this.customer.FirstName,
      LastName: this.customer.LastName,
      Email: this.customer.Email,
      Address: this.customer.Address,
      DOB: '1990-01-01',
      Contact: this.customer.Contact,
    });
  } catch (error) {
    console.error(error)
  }
}

 ngOnChanges(changes: SimpleChanges): void {
   
 }

 CreateCustomer()
 {
  try {
    
  } catch (error) {
    console.error()
  } 
 }

 UpdateCustomer()
 {
  try {

    //this.customerForm.get('FirstName')?.value;  // to get the individual values of form 
    //let formValues = this.customerForm.value  // to get all values of form
    this.customer.FirstName = this.customerForm.get('FirstName')?.value; 
    this.customer.LastName = this.customerForm.get('LastName')?.value; 
    this.customer.Address = this.customerForm.get('Address')?.value; 
    this.customer.Contact = this.customerForm.get('Contact')?.value; 
    this.customer.DOB = this.customerForm.get('DOB')?.value; 
    this.customer.Email = this.customerForm.get('Email')?.value; 
    this.customerservice.updateCustomerDetails(this.customer);
    this.disablefields();
  } catch (error) {
    console.error(error);
  }
 }

 submitForm()
 {
  try {
    if (this.customerForm.valid) {
        if(this.mode.toUpperCase() == "UPDATE") this.UpdateCustomer();
        else this.CreateCustomer();
      
    }
    else
    {
      console.log('Form is invalid')
    }
  } catch (error) {
    
  }
  
 }




}
