import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ScanService {
  constructor(private http: HttpClient) {}

  getULDs(shipmentCode: string) {
    return this.http.get(`https://cat-fact.herokuapp.com/facts/`);
  }
}
