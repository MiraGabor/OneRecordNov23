export namespace ChecksheetActions {
  export class submitChecksheet {
    public static readonly type = '[CheckSheet] Submit';
    public constructor() {} // todo include checksheet
  }

  export class getShipment {
    public static readonly type = '[CheckSheet] Get Shipment';
    public constructor(public shipmentCode: string) {}
  }

  export class getChecksheet {
    public static readonly type = '[CheckSheet] Get Checksheet';
    public constructor(public uldId: string) {}
  }
}
