import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavigationComponent } from './Navigation/navigation/navigation.component';
import { RouterModule } from '@angular/router';
import { NavigationHeadingComponent } from './Navigation/navigation/navigation-heading/navigation-heading.component';



@NgModule({
  declarations: [NavigationComponent
    ,NavigationHeadingComponent
    
  ],
  imports: [
    CommonModule
    ,RouterModule
  ],
  exports:[NavigationComponent
    ,NavigationHeadingComponent
  ]
})
export class SharedModule { }
