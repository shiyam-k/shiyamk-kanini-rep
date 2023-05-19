import { Component } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent {
  ownerName = "No One"
  company = "Good company"
  contacts = [
      {
        contactType : "Phone",
        contact : "807060",
        contactIcon : '../assets/phone.png'
      },
      {
        contactType : "Whatsapp",
        contact : "909090909",
        contactIcon : '../assets/whatsapp.png'
      },
      {
        contactType : "Mail",
        contact : "noone@mail.com",
        contactIcon : '../assets/gmail.png'
      },
      {
        contactType : "Address",
        contact : "221b,bakers street",
        contactIcon : '../assets/address.png'
      }
  ]
}
