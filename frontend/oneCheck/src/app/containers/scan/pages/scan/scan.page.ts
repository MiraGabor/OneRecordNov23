import { Component, NgZone, OnInit } from '@angular/core';
import { UntypedFormControl, UntypedFormGroup } from '@angular/forms';
import {
  Barcode,
  BarcodeFormat,
  BarcodeScanner,
  LensFacing,
} from '@capacitor-mlkit/barcode-scanning';
import { AlertController, ModalController } from '@ionic/angular';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { CheckSheetModalComponent } from 'src/app/containers/checksheet/modals/check-sheet-modal/check-sheet-modal.component';
import { SelectUldModalComponent } from 'src/app/containers/checksheet/modals/select-uld-modal/select-uld-modal.component';
import { ChecksheetActions } from 'src/app/containers/checksheet/state/checksheet.actions';
import { User } from 'src/app/containers/user/models/user.model';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';

@Component({
  selector: 'scan-page',
  templateUrl: 'scan.page.html',
  styleUrls: ['scan.page.scss'],
})
export class ScanPage implements OnInit {
  public userLoggedIn$: Observable<boolean> | undefined;
  public userRole$: Observable<string | undefined> | undefined;
  public user$: Observable<User | undefined> = this.store.select(
    UserStateSelectors.user
  );

  public scannnerLoading = false;

  // Scanner
  public readonly barcodeFormat = BarcodeFormat;
  public readonly lensFacing = LensFacing;
  public formGroup = new UntypedFormGroup({
    formats: new UntypedFormControl([]),
    lensFacing: new UntypedFormControl(LensFacing.Back),
    googleBarcodeScannerModuleInstallState: new UntypedFormControl(0),
    googleBarcodeScannerModuleInstallProgress: new UntypedFormControl(0),
  });
  public barcodes: Barcode[] = [];
  public isSupported = false;
  public isPermissionGranted = false;

  constructor(
    public store: Store,
    private readonly ngZone: NgZone,
    private alertCtrl: AlertController,
    private modalCtrl: ModalController
  ) {}

  public ngOnInit(): void {
    this.userLoggedIn$ = this.store.select(UserStateSelectors.userLoggedIn);
    this.userRole$ = this.store.select(UserStateSelectors.userRole);

    this._scannerSetup();
  }

  public async scan(): Promise<void> {
    this.scannnerLoading = true; // todo not working on real device --> change detection?

    const formats = this.formGroup.get('formats')?.value || [];
    const { barcodes } = await BarcodeScanner.scan({
      formats,
    });
    this.barcodes = barcodes;

    this.scannnerLoading = false;

    // todo replace Alert with API Call
    const alert = await this.alertCtrl.create({
      header: 'Barcode scanned successfully',
      message: `${barcodes[0].rawValue}`,
      buttons: ['Close'],
    });

    await alert.present();
  }

  public async presentDummyChecksheet(): Promise<void> {
    const modal = await this.modalCtrl.create({
      component: CheckSheetModalComponent,
    });

    await modal.present();
  }

  public async presentDummySelectUldModal(): Promise<void> {
    const modal = await this.modalCtrl.create({
      component: SelectUldModalComponent,
    });

    await modal.present();
  }

  private _scannerSetup(): void {
    BarcodeScanner.isSupported().then((result) => {
      this.isSupported = result.supported;
    });
    BarcodeScanner.checkPermissions().then((result) => {
      this.isPermissionGranted = result.camera === 'granted';
    });
    BarcodeScanner.removeAllListeners().then(() => {
      BarcodeScanner.addListener(
        'googleBarcodeScannerModuleInstallProgress',
        (event) => {
          this.ngZone.run(() => {
            console.log('googleBarcodeScannerModuleInstallProgress', event);
            const { state, progress } = event;
            this.formGroup.patchValue({
              googleBarcodeScannerModuleInstallState: state,
              googleBarcodeScannerModuleInstallProgress: progress,
            });
          });
        }
      );
    });
  }
}
