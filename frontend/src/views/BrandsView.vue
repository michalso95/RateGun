<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
        <ViewToolbar
          class = "view-toolbar"
          :previousRoute = "previous"
          title = 'Brands'
          @onSearchTextInput = "filterByName"
        />

      <div class="view-content">
        <v-card class="d-flex flex-wrap align-start" flat tile>
          <v-card
            v-for="item in filteredData"
            :key="item.id"
            class="mx-8 mt-5"
            min-width="20%"
            max-width="20%"
            elevation="10"
            :to="currentRoute+'/' + item.link"
          >
            <v-card-title>
              <v-icon>mdi-pistol</v-icon> <v-spacer></v-spacer> {{ item.title }}
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
      </div>
    </v-sheet>
  </div>
</template>

<script>
import ViewToolbar from '../components/ViewToolbr.vue';

export default {
  name: "BrandsView",

  components: {
    ViewToolbar
  },

  data: () => ({
    previous: '',
    filterByNameString: '',
    brands: [
     {
        id: 0,
        title: "Beretta",
        description: "Jedno zdanie",
        link: "Beretta",
      },
      {
        id: 1,
        title: "CZ",
        description: "Jedno zdanie",
        link: "CZ",
      },
      {
        id: 2,
        title: "Colt",
        description: "Jedno zdanie",
        link: "Colt",
      },
      {
        id: 3,
        title: "Need",
        description: "Jedno zdanie",
        link: "Need",
      },
      {
        id: 4,
        title: "More",
        description: "Jedno zdanie",
        link: "More",
      },
      {
        id: 5,
        title: "Data",
        description: "Jedno zdanie",
        link: "Data",
      }
    ],
  }),

  computed: {
    filteredData() {
      return this.brands.filter(x=> x.title.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
    },
    currentRoute() {
      return this.$route.fullPath;
    }
  },

  beforeRouteEnter(to, from, next) {
    next(component => {
      component.previous = from.path;
    });
  },

  methods: {
    filterByName(input) {
      this.filterByNameString = input;
    }
  }

};
</script>

<style scoped lang="scss">
.view-container {
  min-height: calc(100vh - 64px);
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;

  .view-toolbar {
    width: 100%;
    flex: 0px;
    max-height: 75px;
    margin-top: 30px;
    margin-bottom: 30px;
    border: 1px solid white;
    padding: 10px;
  }

  .view-content {
    width: 100%;
    flex: 1;
    overflow: hidden;
    padding-top: 30px;
    padding-bottom: 30px;
    padding: 10px;
    min-height: calc(100vh - 64px);
    margin: auto;
  }
}
</style>
