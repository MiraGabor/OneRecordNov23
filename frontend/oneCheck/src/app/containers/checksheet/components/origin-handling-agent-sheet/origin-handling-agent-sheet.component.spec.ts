import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { OriginHandlingAgentSheetComponent } from './origin-handling-agent-sheet.component';

describe('OriginHandlingAgentSheetComponent', () => {
  let component: OriginHandlingAgentSheetComponent;
  let fixture: ComponentFixture<OriginHandlingAgentSheetComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ OriginHandlingAgentSheetComponent ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(OriginHandlingAgentSheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
