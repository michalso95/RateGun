<template>
  <div class="mx-auto px-10">
    <v-card
      class="mx-auto mt-5"
      min-width="100%"
      elevation="5"
    >
      <v-card-title>
        {{ review.title }}
      </v-card-title>

      <v-card-subtitle>
        {{ review.text }}
      </v-card-subtitle>
    </v-card>
  </div>
</template>

<script lang="js">

export default {
  name: "GunReviewItem",

  props: {
    review: Object
  },

  data: () => ({

  }),

  mounted() {
    console.log(this.review);
  }
}
</script>
