import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MovielibraryComponent } from './movielibrary.component';

describe('MovielibraryComponent', () => {
  let component: MovielibraryComponent;
  let fixture: ComponentFixture<MovielibraryComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MovielibraryComponent]
    });
    fixture = TestBed.createComponent(MovielibraryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
