import { Injectable } from '@angular/core';

export class configuration{
  api :string ='';
}


@Injectable({
  providedIn: 'root',
})
export class ConfigurationService {
  private config!: configuration;

  async loadConfig(): Promise<void> {
    try {
      const response = await fetch('/config.json');
      this.config = await response.json();
    } catch (error) {
      console.error('Could not load config.json', error);
    }
  }

  get settings(): configuration {
    return this.config;
  }
}
