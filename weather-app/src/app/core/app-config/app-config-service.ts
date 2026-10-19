import { Injectable } from '@angular/core';
import { envVariables } from './env_variables';

@Injectable({
  providedIn: 'root',
})

export class AppConfigService {
  private config = envVariables ;
  
  get nodeEnv(): string {
    return this.config.node_env;
  }

  get isProd(): boolean {
    return this.config.node_env === 'production' || this.config.node_env === 'prod';
  }

  get apiUrl(): string {
    return this.config.apiUrl;
  }
}
