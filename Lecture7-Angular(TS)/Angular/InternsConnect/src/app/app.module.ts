import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { InternNavbarComponent } from './intern-navbar/intern-navbar.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { EmployeeDataViewComponent } from './employee-data-view/employee-data-view.component';

@NgModule({
  declarations: [
    AppComponent,
    InternNavbarComponent,
    EmployeeDataViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
