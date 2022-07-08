import { ActionContext, Module } from "vuex";

import axios from "axios";
import {getOrigin} from '../services/ConnectionService';

import { RootState } from "./index";
import { ADD_GUN, SET_GUNS } from "./mutations";
import { GET_GUNS } from "./actions";
import { GunModel } from "../models";

export interface GunsState {
  all: Array<GunModel>;
}

export const guns: Module<GunsState, RootState> = {
  state: {
    all: []
  },

  mutations: {
    [ADD_GUN](state: GunsState, gun: GunModel) {
      state.all.push(gun);
    },

    [SET_GUNS](state: GunsState, guns: Array<GunModel>) {
      state.all = guns;
    }
  },

  actions: {
    async [GET_GUNS](context: ActionContext<GunsState, RootState>) {
      const url = getOrigin() + "/guns";
      await axios.get(url).then(r => {
        context.commit(SET_GUNS, r.data);
      });
    }
  }
};
