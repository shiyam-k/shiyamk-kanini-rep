import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup,FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-reactive-forms',
  templateUrl: './reactive-forms.component.html',
  styleUrls: ['./reactive-forms.component.css']
})
export class ReactiveFormsComponent  {
  // registerForm:FormGroup = new FormGroup({
  //     credentials : new FormGroup({
  //       userName : new FormControl('sjh'),
  //     password : new FormControl(''),
  //     confirmPassword : new FormControl(''),
  //     }),
  //     newInput : new FormControl(''),
  //     address : new FormGroup({
  //       doorNo : new FormControl(''),
  //       streetName : new FormControl(''),
  //       city : new FormControl('')
  //     })
  // })
  constructor(private formBuilder: FormBuilder) { }

  registerForm = this.formBuilder.group({
    credentials : this.formBuilder.group({
      userName : ['mayihs'],
    password : [''],
    confirmPassword : [''],
    }),
    newInput : [''],
    address : this.formBuilder.group({
      doorNo : [''],
      streetName : [''],
      city : ['']
    })
  })



  GetJSON(){
    let json = document.querySelector('#json')
    if(json?.classList.contains('hidden')){
      json?.classList.remove('hidden')
    json?.setAttribute('class', 'visible')
    }
    else{
      json?.setAttribute('class','hidden')
    }    
  }
  }


  

  

  
