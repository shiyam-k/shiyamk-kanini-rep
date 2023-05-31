import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
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
import { MovieLibraryService } from './movie-library.service';

import { HttprequestComponent } from './httprequest/httprequest.component';

import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsComponent } from './reactive-forms/reactive-forms.component';
import { ReactiveformsvalidationsComponent } from './reactiveformsvalidations/reactiveformsvalidations.component';
import { MovielibraryComponent } from './movielibrary/movielibrary.component';

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
    HttprequestComponent,
    ReactiveFormsComponent,
    ReactiveformsvalidationsComponent,
    MovielibraryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [MovieLibraryService],
  bootstrap: [AppComponent]
})
export class AppModule {
  myTextBoxName :string = ""
 }
