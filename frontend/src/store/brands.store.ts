import { ActionContext, Module } from "vuex";

import axios from "axios";
import {getOrigin} from '../services/ConnectionService';

import { RootState } from "./index";
import { ADD_BRAND, SET_BRANDS } from "./mutations";
import { GET_BRANDS, EDIT_BRAND } from "./actions";
import { ManufacturerModel } from "../models";

export interface BrandsState {
  all: Array<ManufacturerModel>;
}

export const brands: Module<BrandsState, RootState> = {
  state: {
    all: []
  },

  mutations: {
    [ADD_BRAND](state: BrandsState, brand: ManufacturerModel) {
      state.all.push(brand);
    },

    [SET_BRANDS](state: BrandsState, brands: Array<ManufacturerModel>) {
      state.all = brands;
    }
  },

  actions: {
    async [GET_BRANDS](context: ActionContext<BrandsState, RootState>) {
      const url = getOrigin() + "/brands";
      await axios.get(url).then(r => {
        context.commit(SET_BRANDS, r.data);
      });
    },
    async [EDIT_BRAND](context: ActionContext<BrandsState, RootState>, brand: ManufacturerModel) {
      const url = getOrigin() + "/brands";
      console.log(url);
      console.log(brand);
    }
  }
};
