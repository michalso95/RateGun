import { ActionContext, Module } from "vuex";

import axios from "axios";
import {getOrigin} from '../services/ConnectionService';

import { RootState } from "./index";
import { ADD_CATEGORY, SET_CATEGORIES } from "./mutations";
import { GET_CATEGORIES } from "./actions";
import { CategoryModel } from "../models";

export interface CategoriesState {
  all: Array<CategoryModel>;
}

export const categories: Module<CategoriesState, RootState> = {
  state: {
    all: []
  },

  mutations: {
    [ADD_CATEGORY](state: CategoriesState, category: CategoryModel) {
      state.all.push(category);
    },

    [SET_CATEGORIES](state: CategoriesState, categories: Array<CategoryModel>) {
      state.all = categories;
    }
  },

  actions: {
    async [GET_CATEGORIES](context: ActionContext<CategoriesState, RootState>) {
      const url = getOrigin() + "/categories";
      await axios.get(url).then(r => {
        context.commit(SET_CATEGORIES, r.data);
      });
    }
  }
};
