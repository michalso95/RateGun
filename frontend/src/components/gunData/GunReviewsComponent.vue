<template>
  <div class="mx-auto dataStyle">
    <h2 class="mb-5">{{ title }}</h2>
    <div v-for="review in reviewsList" :key="review.id">
      <GunReviewItem :review="review" />
    </div>
  </div>
</template>

<script lang="js">

import GunReviewItem from "../GunReviewItem";
import {mapState} from 'vuex';

export default {
  name: "GunReviewsComponent",

  components: {
    GunReviewItem,
  },

  props: {
    title: String,
  },

  data: () => ({

  }),

  computed: {
    ...mapState({
      state: state => {
        return state;
      },
    }),
    reviewsList() {
        return this.state.reviews.all;
    },
  }
}
</script>
