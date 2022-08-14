<template>
<div class="view-container">
  <v-sheet elevation="10" color="dark" rounded width="80%" height="95%" class="px-5 py-5">
    <ViewToolbar
        ref="viewToolbarComponent"
        class="view-toolbar"
        :previousRoute="previous"
        title="Management"
        :hideSearch=true
      >
      </ViewToolbar>
    <GunsManagementPane />
    <BrandsManagementPane />
    <CategoriesManagementPane />
    <GunPlantsManagementPane />
  </v-sheet>
</div>
</template>

<script lang="js">

import ViewToolbar from "../components/ViewToolbar";
import BrandsManagementPane from '../components/manage/BrandsManagementPane';
import CategoriesManagementPane from '../components/manage/CategoriesManagementPane';
import GunPlantsManagementPane from '../components/manage/GunPlantsManagementPane';
import GunsManagementPane from '../components/manage/GunsManagementPane';

export default {
  name: "SpecificGunItem",

  components: {
    ViewToolbar,
    BrandsManagementPane,
    CategoriesManagementPane,
    GunPlantsManagementPane,
    GunsManagementPane
  },

  data: () => ({
    previous: "",
  }),

  computed: {
    currentRoute() {
      if (this.$route.path.endsWith('/')) {
        return this.$route.path;
      }
      return this.$route.path + '/';
    }
  },

  beforeRouteEnter(to, from, next) {
    next(component => {
      component.previous = from.path;
    });
  },
};
</script>

<style lang="scss">

</style>
