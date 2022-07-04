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
}