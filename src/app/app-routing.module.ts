import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { CustomerModule } from '../Customer/customer/customer.module';
//import { NavigationComponent } from '../Navigation/navigation/navigation.component';
//import { CreateCustomerComponent } from '../Customer/CreateCustomer/create-customer/create-customer.component';


const routes: Routes = [
  
    { 
      path: '', 
      redirectTo: '', 
      pathMatch: 'full' 
    },
    { 
      path: 'customers', 
      //component: CreateCustomerComponent
      loadChildren: () => import('../Customer/customer/customer.module').then(m => m.CustomerModule) 
    },
    { 
      path: '**', 
      redirectTo: '' 
    } // Wildcard for unknown paths
];

@NgModule({
  imports: [RouterModule.forRoot(routes)
   
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
