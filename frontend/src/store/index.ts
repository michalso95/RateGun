import Vue from 'vue'
import Vuex from 'vuex'

import {guns, GunsState} from './guns.store';
import {categories, CategoriesState} from './categories.store';
import {brands, BrandsState} from './brands.store';

Vue.use(Vuex);

export interface RootState {

  guns? : GunsState;
  categories? : CategoriesState;
  brands? : BrandsState;
}

export default new Vuex.Store({
  modules: {
    guns: guns,
    categories: categories,
    brands: brands
  }
})
