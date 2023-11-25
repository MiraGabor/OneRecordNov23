export namespace UserActions {
  export class Login {
    public static readonly type = '[User] Login';
    public constructor(public userId: string) {}
  }

  export class Logout {
    public static readonly type = '[User] Logout';
    public constructor() {}
  }

  export class SetRole {
    public static readonly type = '[User] Set Role';
    public constructor(public role: string | undefined) {} // todo should be role-id
  }
}
