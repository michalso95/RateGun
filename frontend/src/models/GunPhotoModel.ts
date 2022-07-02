import {GunModel} from './GunModel';

export interface GunPhotoModel {
  id: string;
  gunId: string;
  gun: GunModel;
  author: string;
  photo: string;
}