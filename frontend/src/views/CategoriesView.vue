<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <ViewToolbar
          class = "view-toolbar"
          :previousRoute = "previous"
          title = 'Categories'
        />

      <div class="view-content">categories ccategories categories</div>
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
    previous: ''
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
  height: calc(100vh - 64px);
  max-height: calc(100vh - 64px);
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
