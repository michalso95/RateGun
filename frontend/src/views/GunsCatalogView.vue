<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <ViewToolbar
        ref="viewToolbarComponent"
        class="view-toolbar"
        :previousRoute="previous"
        :title="title + ' Catalog'"
        @onSearchTextInput = "filterByName"
      >
      </ViewToolbar>

      <div class="view-content">
        <CatalogComponent :filteredData="filteredData"/>
      </div>
    </v-sheet>
  </div>
</template>

<script lang="js">
import {mapState} from 'vuex';
import ViewToolbar from "../components/ViewToolbar";
import CatalogComponent from "../components/CatalogComponent";
export default {
  name: "GunsCatalogView",

  components: {
    ViewToolbar,
    CatalogComponent
  },

  props: {
    categoryName: String,
    brandName: String,
  },

  data: () => ({
    title: 'Guns',
    previous: "",
    filterByNameString: '',
  }),

  computed: {
    ...mapState({
      state: state => {
        return state;
      },
    }),
    filteredData() {
        return this.state.guns.all.filter(x=> x.model.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
    },
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

  methods: {
    filterByName(input) {
      this.filterByNameString = input;
    },
    async clearFilter(){
      await this.$refs.viewToolbarComponent.clearSearchField()
    }
  }
};
</script>


