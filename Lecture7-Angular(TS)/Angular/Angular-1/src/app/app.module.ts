import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {FormsModule} from '@angular/forms';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { ProfileComponent } from './profile/profile.component';
import { LoginComponent } from './login/login.component';

import { SelectSPipe } from './pipes/product.pipe';
import { ClickRenderComponent } from './click-render/click-render.component';
import { StudentsComponent } from './students/students.component';
import { StudentsAComponent } from './students-a/students-a.component';

import { StudentService } from './student.service';
import { HttprequestComponent } from './httprequest/httprequest.component';

import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    ContactComponent,
    CalculatorComponent,
    ProfileComponent,
    LoginComponent,
    SelectSPipe,
    ClickRenderComponent,
    StudentsComponent,
    StudentsAComponent,
    HttprequestComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [StudentService],
  bootstrap: [AppComponent]
})
export class AppModule {
  myTextBoxName :string = ""
 }
