import {
  ManufacturerModel,
  GunPlantModel,
  MagazineCapacityModel,
  BulletCalModel,
  GunPhotoModel,
  ReviewModel
} from './index';

export interface GunModel {
  id: string;
  model: string;
  version: string;
  type: string;
  manufacturerId: string;
  manufacturer: ManufacturerModel;
  gunPlantId: string;
  gunPlant: GunPlantModel;
  productionBegin: number;
  productionFinish: number;
  magazineCapacityId: string;
  magazineCapacity: MagazineCapacityModel;
  bulletCalId: string;
  bulletCal: BulletCalModel;
  descrGeneral: string;
  descrTech: string;
  descrCuriosities: string;
  descrHistory: string;
  bibliography: string;
  gunPhotos: Array<GunPhotoModel>;
  reviews: Array<ReviewModel>;
}