import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterScore } from './register-score';

describe('RegisterScore', () => {
  let component: RegisterScore;
  let fixture: ComponentFixture<RegisterScore>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RegisterScore]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegisterScore);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
