export namespace ChecksheetActions {
  export class submitChecksheet {
    public static readonly type = '[CheckSheet] Submit';
    public constructor() {} // todo include checksheet
  }

  export class getULDs {
    public static readonly type = '[CheckSheet] Get ULDs';
    public constructor(shipmentCode: string) {} // todo include checksheet
  }
}
