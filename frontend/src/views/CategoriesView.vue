<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <ViewToolbar
          class = "view-toolbar"
          :previousRoute = "previous"
          title = 'Categories'
        />

      <div class="view-content">
            <v-card
              class="d-flex flex-wrap"
              flat
              tile
            >
              <v-card
                v-for="item in categories"
                :key="item.id"
                class="mx-auto mt-3"
                min-width="350"
                max-width="350"
              >
                <v-img
                  v-bind:src= item.image
                  height="200px"
                ></v-img>

                <v-card-title>
                  {{item.title}}
                </v-card-title>

                <v-card-subtitle>
                  {{item.description}}
                </v-card-subtitle>

                <v-card-actions>
                  <v-btn
                    color="blue lighten-2"
                    text
                  >
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
  name: "CategoriesView",

  components: {
    ViewToolbar
  },

  data: () => ({
    previous: '',
    categories: [
      {
        id: 0,
        title: 'Karabiny',
        image: '/images/rifle.png',
        description: 'Bla bla bla o karabinach'
      },
      {
        id: 1,
        title: 'Pistolety maszynowe',
        image: '/images/machinePistol.png',
        description: 'Bla bla bla o pistoletach maszynowych'
      },
      {
        id: 2,
        title: 'Broń krótka',
        image: '/images/pistol.png',
        description: 'Bla bla bla o broni krótkiej'
      },
      {
        id: 3,
        title: 'Karabiny wyborowe',
        image: '/images/sniper.png',
        description: 'Bla bla bla o karabinach ale wyborowych'
      },
      {
        id: 4,
        title: 'Akcesoria',
        image: '/images/accessories.png',
        description: 'Bla bla bla o akcesoriach'
      },
      {
        id: 5,
        title: 'Karabiny again',
        image: '/images/rifle.png',
        description: 'Bla bla bla o tym że potrzebujemy danych'
      },
      {
        id: 6,
        title: 'Pistolety again',
        image: '/images/pistol.png',
        description: 'Bla bla bla o pistoletach again'
      },
      {
        id: 7,
        title: 'Inna kategoria',
        image: '/images/logo.png',
        description: 'Bla bla bla o innych rzeczach'
      },
    ]
  }),

  beforeRouteEnter(to, from, next) {
    next(component => {
      component.previous = from.path;
    });
  },
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
  }
}
</style>
