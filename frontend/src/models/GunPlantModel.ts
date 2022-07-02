import {GunModel} from './GunModel';

export interface GunPlantModel {
  id: string;
  name: string;
  descr: string;
  location: string;
  yearEstablish: number;
  yearClose: number;
  isRunning: boolean;
  guns: Array<GunModel>;
}