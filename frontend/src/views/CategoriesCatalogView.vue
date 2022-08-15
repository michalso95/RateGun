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
  name: "CategoriesCatalogView",

  components: {
    ViewToolbar,
    CatalogComponent
  },

  props: {
    categoryName: String,
    brandName: String,
  },

  data: () => ({
    title: 'Categories',
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
      if (this.categoryName && this.brandName) {
        this.setTitle('Guns');
        return this.state.guns.all.filter(x=> x.model.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
      }
      else if (this.categoryName) {
        this.setTitle('Brands');
        return this.state.brands.all.filter(x=> x.name.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
      }
      else {
        this.setTitle('Categories');
        return this.state.categories.all.filter(x=> x.name.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
      }

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
    setTitle(title){
      this.title = title;
    },
    async clearFilter(){
      await this.$refs.viewToolbarComponent.clearSearchField()
    }
  }
};
</script>

