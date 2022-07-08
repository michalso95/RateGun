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
    title: 'Brands',
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
        return this.state.guns.all.filter(x=> x.name.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
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
