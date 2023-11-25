import { Component, OnInit } from '@angular/core';
import { Store } from '@ngxs/store';
import { UserActions } from '../../state/user.actions';
import { mockUsers } from '../../state/mockUsers';
import { User } from '../../models/user.model';

@Component({
  selector: 'app-login-mask',
  templateUrl: './login-mask.component.html',
  styleUrls: ['./login-mask.component.scss'],
})
export class LoginMaskComponent implements OnInit {
  public isLoading = false;
  public users: User[] = mockUsers;
  public isModalOpen = false;

  constructor(public store: Store) {}

  ngOnInit() {}

  public login(userId: string): void {
    this.isLoading = true;
    this.isModalOpen = false;

    // todo provide user ID
    this.store.dispatch(new UserActions.Login(userId)).subscribe(() => {
      this.isLoading = false;
      console.log('login successful');
    });
  }

  setOpen(isOpen: boolean) {
    this.isModalOpen = isOpen;
  }
}
