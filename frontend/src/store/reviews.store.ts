import { ActionContext, Module } from "vuex";

import axios from "axios";
import {getOrigin} from '../services/ConnectionService';

import { RootState } from "./index";
import { ADD_REVIEW, SET_REVIEWS } from "./mutations";
import { GET_REVIEWS } from "./actions";
import { ReviewModel } from "../models";

export interface ReviewsState {
  all: Array<ReviewModel>;
}

export const reviews: Module<ReviewsState, RootState> = {
  state: {
    all: []
  },

  mutations: {
    [ADD_REVIEW](state: ReviewsState, review: ReviewModel) {
      state.all.push(review);
    },

    [SET_REVIEWS](state: ReviewsState, reviews: Array<ReviewModel>) {
      state.all = reviews;
    }
  },

  actions: {
    async [GET_REVIEWS](context: ActionContext<ReviewsState, RootState>) {
      const url = getOrigin() + "/reviews";
      await axios.get(url).then(r => {
        context.commit(SET_REVIEWS, r.data);
      });
    }
  }
};
