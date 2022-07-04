<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
        <ViewToolbar
          class = "view-toolbar"
          :previousRoute = "previous"
          title = 'Brands'
        />

      <div class="view-content">
        <v-list dense>
          <v-subheader>Marki</v-subheader>
          <v-list-item-group v-model="selectedItem" color="primary">
            <v-list-item v-for="brand in brandsArray" :key="brand.id">
              <v-list-item-icon>
                <v-icon>mdi-pistol</v-icon>
              </v-list-item-icon>
              <v-list-item-content>
                <v-list-item-title v-text="brand.name"></v-list-item-title>
              </v-list-item-content>
            </v-list-item>
          </v-list-item-group>
        </v-list>
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
    brandsArray: [
      {
        id: 0,
        name: "Beretta",
      },
      {
        id: 1,
        name: "Browning",
      },
      {
        id: 2,
        name: "Heckler&Koch",
      },
    ],
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
    padding:10px;
  }
}
</style>
