import {UserModel} from './UserModel';

export interface AccessLevelModel {
  id: string;
  name: string;
  permissions: string;
  users: Array<UserModel>;
}