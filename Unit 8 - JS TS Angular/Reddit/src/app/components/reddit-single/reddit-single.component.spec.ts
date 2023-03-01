import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RedditSingleComponent } from './reddit-single.component';

describe('RedditSingleComponent', () => {
  let component: RedditSingleComponent;
  let fixture: ComponentFixture<RedditSingleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RedditSingleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RedditSingleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
