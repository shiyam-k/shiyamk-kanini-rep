import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Template } from './students';
import { PostDir } from './movieLibrary';


@Injectable({
  providedIn: 'root'
})
export class MovieLibraryService  {
  private directorURL = 'https://localhost:5000/api/Director'
  private directorPostURL = 'https://localhost:5000/api/Director'
  constructor(private http : HttpClient) { }
  GetMovies(){
    return this.http.get<Template[]>(this.directorURL)
  }
  PostDirector(director: PostDir): Observable<any> {
    return this.http.post(this.directorPostURL, director);
  }
}
