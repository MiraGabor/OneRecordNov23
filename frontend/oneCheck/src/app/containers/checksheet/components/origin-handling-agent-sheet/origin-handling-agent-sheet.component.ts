import { Component, Input, OnInit } from '@angular/core';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';
import { OriginHandlingAgentSheetDto } from 'src/model/originHandlingAgentSheetDto';

@Component({
  selector: 'app-origin-handling-agent-sheet',
  templateUrl: './origin-handling-agent-sheet.component.html',
  styleUrls: ['./origin-handling-agent-sheet.component.scss'],
})
export class OriginHandlingAgentSheetComponent implements OnInit {
  public userRole$: Observable<string | undefined> | undefined;
  public canEdit = false;

  @Input() public originHandlingAgentSheet:
    | OriginHandlingAgentSheetDto
    | undefined;

  constructor(private store: Store) {}

  public ngOnInit(): void {
    this.userRole$ = this.store.select(UserStateSelectors.userRole);

    this.userRole$.subscribe((role) => {
      this.canEdit = role === 'export'; // todo change role
    });
  }
}
