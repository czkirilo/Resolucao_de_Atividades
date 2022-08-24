import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContatComponent } from './contat.component';

describe('ContatComponent', () => {
  let component: ContatComponent;
  let fixture: ComponentFixture<ContatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContatComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
