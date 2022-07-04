import {ReviewModel} from './ReviewModel'

export interface BulletCalModel {
  id: string;
  name: string;
  descr: string;
  inventor: string;
  inventorCountry: string;
  yearInvented: number;
  yearProductionStart: number;
  yearProductionEnd: number;
  isProduce: boolean;
  reviews: Array<ReviewModel>;
}