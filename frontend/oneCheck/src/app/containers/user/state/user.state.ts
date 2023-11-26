import { Injectable } from '@angular/core';
import { Action, State, StateContext } from '@ngxs/store';
import { Observable, delay, of } from 'rxjs';
import { User } from '../models/user.model';
import { mockUsers } from './mockUsers';
import { UserActions } from './user.actions';

export interface UserStateModel {
  user?: User;
  role: 'import' | 'transit' | 'export' | undefined;
}

@State<UserStateModel>({
  name: 'user',
  defaults: {
    user: undefined,
    role: undefined, // todo undefgined
  },
})
@Injectable()
export class UserState {
  @Action(UserActions.Login)
  public login(
    ctx: StateContext<UserStateModel>,
    action: UserActions.Login
  ): Observable<boolean> {
    const state = ctx.getState();
    const user = mockUsers.find((user) => user.id === action.userId);
    let successful = false;

    if (user) {
      // fake delay 2 sec makes login look real
      setTimeout(() => {
        ctx.setState({
          ...state,
          user: user,
          role: user.role as any, // todo murks
        });

        successful = true;
      }, 2000);
    }

    return of(successful).pipe(delay(2000));
  }

  // todo test
  @Action(UserActions.Logout)
  public logout(ctx: StateContext<UserStateModel>): void {
    const state = ctx.getState();

    ctx.setState({
      ...state,
      user: undefined,
    });
  }

  @Action(UserActions.SetRole)
  public setUserRole(
    ctx: StateContext<UserStateModel>,
    action: UserActions.SetRole
  ): void {
    const state = ctx.getState();

    if (action.role) {
      ctx.setState({
        ...state,
        role: action.role as any, // todo murks
      });
    }
  }
}
