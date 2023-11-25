export interface Checksheet {
  checkSheetId: string;
  preparationSheet: PreparationSheet;
  originHandlingAgentSheet: OriginHandlingAgentSheet;
  inboundTransitSheets: InboundTransitSheet[];
  destinationHandlingAgentSheet: DestinationHandlingAgentSheet;
  destinationConsigneeSheet: DestinationConsigneeSheet;
}

export interface PreparationSheet {
  checkSheetId: string;
  date: Date;
  time: Time;
  sealNumber: string;
  signature: string;
  name: string;
  batteryStatusInPercent: number;
  uldNumber: string;
  awbNumber: number;
  isBatteryCharged: boolean;
  isContainerDamaged: boolean;
  routing: string[];
  goodsPrecooledAtTemps: number;
  uldPrecooledTemp: number;
  tempSetting: number;
  acceptedTempRange: number;
  emergencyPhone: string;
}

export interface Date {
  year: number;
  month: number;
  day: number;
  dayOfWeek: number;
  dayOfYear: number;
  dayNumber: number;
}

export interface Time {
  hour: number;
  minute: number;
  second: number;
  millisecond: number;
  microsecond: number;
  nanosecond: number;
  ticks: number;
}

export interface OriginHandlingAgentSheet {
  checkSheetId: string;
  date: Date2;
  time: Time2;
  sealNumber: string;
  signature: string;
  name: string;
  batteryStatusInPercent: number;
  isContainerDamaged: boolean;
  isContainerOperating: boolean;
  displayTemp: number;
  isAlert: boolean;
  isBlueLightOn: number;
  alertDisplayed: string;
  setTempOnDisplay: number;
  is5AdaptersPresents: boolean;
}

export interface Date2 {
  year: number;
  month: number;
  day: number;
  dayOfWeek: number;
  dayOfYear: number;
  dayNumber: number;
}

export interface Time2 {
  hour: number;
  minute: number;
  second: number;
  millisecond: number;
  microsecond: number;
  nanosecond: number;
  ticks: number;
}

export interface InboundTransitSheet {
  checkSheetId: string;
  date: Date3;
  time: Time3;
  sealNumber: string;
  signature: string;
  name: string;
  batteryStatusInPercent: number;
  inboundCheckAirport: string;
  isContainerOperating: boolean;
  isContainerDamaged: boolean;
  displayedTemp: number;
  blueLight: number;
  isAlarmDisplayed: boolean;
}

export interface Date3 {
  year: number;
  month: number;
  day: number;
  dayOfWeek: number;
  dayOfYear: number;
  dayNumber: number;
}

export interface Time3 {
  hour: number;
  minute: number;
  second: number;
  millisecond: number;
  microsecond: number;
  nanosecond: number;
  ticks: number;
}

export interface DestinationHandlingAgentSheet {
  checkSheetId: string;
  date: Date4;
  time: Time4;
  sealNumber: string;
  signature: string;
  name: string;
  batteryStatusInPercent: number;
  inboundCheckAirport: string;
  isContainerOperating: boolean;
  isContainerDamaged: boolean;
  displayedTemp: number;
  inboundCheckAirportCode: string;
  blueLight: number;
  isAlarmDisplayed: boolean;
  setTempOnDisplay: number;
}

export interface Date4 {
  year: number;
  month: number;
  day: number;
  dayOfWeek: number;
  dayOfYear: number;
  dayNumber: number;
}

export interface Time4 {
  hour: number;
  minute: number;
  second: number;
  millisecond: number;
  microsecond: number;
  nanosecond: number;
  ticks: number;
}

export interface DestinationConsigneeSheet {
  checkSheetId: string;
  date: Date5;
  time: Time5;
  sealNumber: string;
  signature: string;
  name: string;
  batteryStatusInPercent: number;
  isContainerDamaged: boolean;
  isContainerOperating: boolean;
  displayTemp: number;
  is5AdaptersPresents: boolean;
  recipientName: string;
  recipientSignature: string;
}

export interface Date5 {
  year: number;
  month: number;
  day: number;
  dayOfWeek: number;
  dayOfYear: number;
  dayNumber: number;
}

export interface Time5 {
  hour: number;
  minute: number;
  second: number;
  millisecond: number;
  microsecond: number;
  nanosecond: number;
  ticks: number;
}
