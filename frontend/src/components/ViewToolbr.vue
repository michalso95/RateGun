<template>
  <v-toolbar
    height        = "33px"
    elevation     = "0"
    color         = "transparent"
  >

    <v-btn
      icon
      :to         = "previous"
    >
      <v-icon>mdi-arrow-left</v-icon>
    </v-btn>

    <v-toolbar-title class="text-h2">{{title}}</v-toolbar-title>

    <v-spacer></v-spacer>

  </v-toolbar>
</template>


<script lang="js">

export default {
  name: 'ViewToolbar',

  props: {
    title: String,
    previousRoute: String,
  },

  computed: {
    previous: {
      get() {
        if (!this.previousRoute || (this.previousRoute === '/')) {
          return '/news';
        }

        return this.previousRoute;
      }
    }
  }
}

</script>