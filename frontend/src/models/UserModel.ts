import {ReviewModel} from './ReviewModel'
import {AccessLevelModel} from './AccessLevelModel'

export interface UserModel {
  id: string;
  name: string;
  accessLvlId: string;
  accessLvl: AccessLevelModel;
  exp: number;
  lvl: number;
  signatureFooter: string;
  avatar: string;
  reviews: Array<ReviewModel>;
}