import { Component, OnInit } from '@angular/core';
import { MovieLibraryService } from '../movie-library.service';
import { FormControl, FormGroup } from '@angular/forms';
import { PostDir } from '../movieLibrary';

@Component({
  selector: 'app-movielibrary',
  templateUrl: './movielibrary.component.html',
  styleUrls: ['./movielibrary.component.css']
})
export class MovielibraryComponent implements OnInit {
  Director : any[] = []
  PostDirector : PostDir = {
    directorName : ""
  }
  constructor(private _movieServices : MovieLibraryService){}
  ngOnInit(): void {
    this._movieServices.GetMovies().subscribe(data => this.Director = data)
  }
  AddDirector(){
    this._movieServices.PostDirector(this.PostDirector)
      .subscribe(
        response => {
          console.log('Director added successfully!', response);
          // Reset the employee object or perform any other actions
          this.PostDirector = {          
            directorName : ""
          };
        },
        error => {
          console.error('Error adding Director:', error);
        });
        window.location.reload();
      }
    
}
