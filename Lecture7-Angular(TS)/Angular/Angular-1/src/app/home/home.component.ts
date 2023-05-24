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
  students: any[] = [
    {
        ID: 'std1001', Name: 'Nivin MMMM',
        DOB: '12/8/1988', Gender: 'Male', CourseFee: 1234.56,
        courses : ['HTML','CSS','JS']
    },
    {
        ID: 'std1002', Name: 'MMMM YYYY', 
        DOB: '10/14/1989', Gender: 'Male', CourseFee: 6666.00,
        courses : ['ReactJS','Angular']
    },
    {
      ID: 'std1003', Name: 'MMMM YYYY', 
      DOB: '10/14/1989', Gender: 'Male', CourseFee: 6666.00,
      courses : ['ReactJS','Angular']
  }
];
studentId: string = "";
searchStudents(): void {
  
}
}
