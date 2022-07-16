import Vue from 'vue'
import Vuex from 'vuex'

import {guns, GunsState} from './guns.store';
import {categories, CategoriesState} from './categories.store';
import {brands, BrandsState} from './brands.store';
import {reviews, ReviewsState} from './reviews.store';

Vue.use(Vuex);

export interface RootState {
  reviews?: ReviewsState;
  guns? : GunsState;
  categories? : CategoriesState;
  brands? : BrandsState;
}

export default new Vuex.Store({
  modules: {
    reviews: reviews,
    guns: guns,
    categories: categories,
    brands: brands
  }
})
