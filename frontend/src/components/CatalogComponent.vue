<template>
  <v-card class="d-flex flex-wrap justify" flat>
    <v-card
      v-for="item in filteredData"
      :key="item.id"
      class="mx-6 mt-4"
      min-width="20%"
      max-width="20%"
      max-height="350px"
      min-height="350px"
      elevation="10"
      :to="currentRoute + item.link"
    >
      <v-img v-bind:src="item.image" height="200px"></v-img>

      <v-card-title>
        {{ item.name }}
      </v-card-title>

      <v-card-subtitle>
        {{ item.description }}
      </v-card-subtitle>

      <v-card-actions>
        <v-btn color="blue lighten-2" text>
          Szczegóły
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-card>
</template>

<script lang="js">

export default {
  name: "CatalogComponent",

  props: {
    filteredData: Array,
  },

  computed: {
    currentRoute() {
      if (this.$route.path.endsWith('/')) {
        return this.$route.path;
      }
      return this.$route.path + '/';
    }
  },

}

</script>

<style scoped lang="scss">
.justify {
  align-items: center;
  justify-content: center;
}
</style>