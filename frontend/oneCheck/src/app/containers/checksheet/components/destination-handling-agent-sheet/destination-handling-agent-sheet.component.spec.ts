import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { DestinationHandlingAgentSheetComponent } from './destination-handling-agent-sheet.component';

describe('DestinationHandlingAgentSheetComponent', () => {
  let component: DestinationHandlingAgentSheetComponent;
  let fixture: ComponentFixture<DestinationHandlingAgentSheetComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ DestinationHandlingAgentSheetComponent ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(DestinationHandlingAgentSheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
