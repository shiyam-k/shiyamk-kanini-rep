import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  clans = [
    {
      id : 1,
      clanName : 'Uzumaki',
      leaderName : 'Ashina ',
      imageURL : '../assets/ashina.jpg',

    },
    {
      id : 2,
      clanName : 'Uchiha',
      leaderName : 'Madara ',
      imageURL : '../assets/madara.png',
      
    },
    {
      id : 3,
      clanName : 'Senju',
      leaderName : 'Hashirama ',
      imageURL : '../assets/hashirama.jpg',
      
    }
  ]
}
