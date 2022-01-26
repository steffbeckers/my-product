import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'MyProduct',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44325',
    redirectUri: baseUrl,
    clientId: 'MyProduct_App',
    responseType: 'code',
    scope: 'offline_access MyProduct',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44325',
      rootNamespace: 'SteffBeckers.MyProduct',
    },
  },
} as Environment;