import { Selector } from '@ngxs/store';
import { UserState, UserStateModel } from './user.state';

export class UserStateSelectors {
  /**
   * Returns if user is logged in
   */
  @Selector([UserState])
  public static userLoggedIn(state: UserStateModel) {
    return state.user ? true : false;
  }

  /**
   * Returns user role (export, import or transit)
   */
  @Selector([UserState])
  public static userRole(state: UserStateModel) {
    return state.role;
  }

  /**
   * Returns user role (export, import or transit)
   */
  @Selector([UserState])
  public static user(state: UserStateModel) {
    return state.user;
  }
}
