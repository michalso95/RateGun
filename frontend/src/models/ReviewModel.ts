import {
  GunModel,
  UserModel
} from './index';

export interface ReviewModel {
  id: string;
  userId: string;
  user: UserModel;
  gunId: string;
  gun: GunModel;
  ratings: Array<Rate>;
  rateGeneral: number;
  rateAccuarcy: number;
  rateDefaultAiming: number;
  rateFailureFree: number;
  rateMaterialQuality: number;
  rateLook: number;
  rateErgonomic: number;
  ratePartsAddsAvailability: number;
  rateModifiable: number;
  descrRate: string;
  visibility: number;
  nonCompilancePoints: number;
  points: number;
  publicationDate: string;
  text: string;
  title: string;
}

export interface Rate {
  type: string;
  name: string;
  points: number;
}