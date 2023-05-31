import { TestBed } from '@angular/core/testing';

import { MovieLibraryService } from './movie-library.service';

describe('MovieLibraryService', () => {
  let service: MovieLibraryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MovieLibraryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
