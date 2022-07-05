<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <ViewToolbar
        class="view-toolbar"
        :previousRoute="previous"
        title="Guns"
        @onSearchTextInput = "filterByName"
      />

      <div class="view-content">
        <v-card class="d-flex flex-wrap" flat >
          <v-card
            v-for="item in filteredData"
            :key="item.id"
            class="mx-8 mt-5"
            min-width="20%"
            max-width="20%"
            elevation="10"
          >
            <v-img v-bind:src="item.image" height="200px"></v-img>

            <v-card-title>
              {{ item.title }}
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
  name: "GunsView",

  components: {
    ViewToolbar
  },

  data: () => ({
    previous: "",
    filterByNameString: '',
    categories: [
      {
        id: 0,
        title: "Pistolet Maszynowy PM – 98",
        image: "/images/rifle.png",
        description: "Bla bla bla o Pistolet Maszynowy PM – 98",
      },
      {
        id: 1,
        title: "Pistolet Maszynowy PM – 06",
        image: "/images/machinePistol.png",
        description: "Bla bla bla o Pistolet Maszynowy PM – 06",
      },
      {
        id: 2,
        title: "CZ Scorpion EVO",
        image: "/images/pistol.png",
        description: "Bla bla bla o evo",
      },
      {
        id: 3,
        title: "CZ 512",
        image: "/images/sniper.png",
        description: "Bla bla bla o 512",
      },
      {
        id: 4,
        title: "CZ-USA Sport",
        image: "/images/accessories.png",
        description: "Bla bla bla o sport",
      },
      {
        id: 5,
        title: "CZ Bren",
        image: "/images/rifle.png",
        description: "Bla bla bla o Bren",
      },
    ],
  }),

  computed: {
    filteredData() {
      return this.categories.filter(x=> x.title.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
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
