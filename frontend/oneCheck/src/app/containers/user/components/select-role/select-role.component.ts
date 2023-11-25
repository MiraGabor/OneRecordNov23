import { ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';
import { Store } from '@ngxs/store';
import { UserActions } from '../../state/user.actions';

@Component({
  selector: 'app-select-role',
  templateUrl: './select-role.component.html',
  styleUrls: ['./select-role.component.scss'],
})
export class SelectRoleComponent implements OnInit {
  public isModalOpen = false;

  @Input() public title = 'Select Role'; // could also be 'Switch Role'

  public constructor(private store: Store, private cd: ChangeDetectorRef) {}

  public ngOnInit() {}

  public setOpen(isOpen: boolean) {
    this.isModalOpen = isOpen;
  }

  public setRole(role: string): void {
    this.store.dispatch(new UserActions.SetRole(role)).subscribe(() => {
      this.setOpen(false);
      this.cd.detectChanges(); // need to manually trigger change detection
    });
  }
}
