import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {
  private configData: any;

  constructor(private http: HttpClient) {}

  loadConfig(): Promise<void> {
    return firstValueFrom(this.http.get('/assets/config.json'))
      .then(config => {
        this.configData = config;
      })
      .catch(error => {
        console.error('Could not load config:', error);
        throw error;
      });
  }

  get apiBaseUrl(): string {
    return this.configData?.apiBaseUrl;
  }

  get authUrl(): string {
    return this.configData?.authUrl;
  }
}
