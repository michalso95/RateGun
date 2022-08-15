import {GunModel} from './GunModel';

export interface ManufacturerModel {
  id: string;
  name: string;
  descrGeneral: string;
  descrHistory: string;
  descrCuriosities: string;
  yearEstablish: number;
  yearClose: number;
  country: string;
  location: string;
  guns: Array<GunModel>;
}