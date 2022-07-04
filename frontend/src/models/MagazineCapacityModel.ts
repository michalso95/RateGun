import {GunModel} from './GunModel';

export interface MagazineCapacityModel {
  id: string;
  capacity: number;
  guns: Array<GunModel>;
}