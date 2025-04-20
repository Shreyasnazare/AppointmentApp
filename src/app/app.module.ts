import { APP_INITIALIZER, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
//import { CustomerModule } from '../Customer/customer/customer.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ConfigService } from '../assets/config.service';
import { HttpClientModule } from '@angular/common/http';
import { NavigationComponent } from '../Navigation/navigation/navigation.component';
import { NavigationHeadingComponent } from '../Navigation/navigation/navigation-heading/navigation-heading.component';
import { SharedModule } from '../shared.module';


export function loadAppConfig(configService: ConfigService) {
 
  return () => configService.loadConfig();
}

@NgModule({
  declarations: [
    AppComponent
   
    

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
   // ,CustomerModule  //commented as imported will make it eager loading , we want lazy-loading
    ,HttpClientModule
    ,SharedModule
    
  ],
  providers: [
    ConfigService,
    {
      provide: APP_INITIALIZER,
      useFactory: loadAppConfig,
      deps: [ConfigService],
      multi: true
    }
  ],
 

  bootstrap: [AppComponent]
})
export class AppModule { }
