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
        <v-row>
          <v-col cols="2">
            <GunDataCategories class="categoriesMenu"/>
          </v-col>
          <v-col>
            <CategoriesView
              v-if="!this.categoryName && !this.brandName && !this.gunName"
            />
            <BrandsView
              v-else-if="this.categoryName && !this.brandName && !this.gunName"
            />
            <GunsView
              v-else-if="this.categoryName && this.brandName && !this.gunName"
            />
            <SpecificGunItem
              v-else-if="this.categoryName && this.brandName && this.gunName"
            />
            <span v-else> LOL nic tu nie ma </span>
          </v-col>
        </v-row>
      </div>
    </v-sheet>
  </div>
</template>

<script lang="js">
import ViewToolbar from '../components/ViewToolbr.vue';
import GunDataCategories from '../components/GunDataCategories.vue';
import CategoriesView from './CategoriesView.vue';
import BrandsView from './BrandsView.vue';
import GunsView from './GunsView.vue';
import SpecificGunItem from '../components/SpecificGunItem.vue';

export default {
  name: "SelectorView",

  props: {
    brandName: String,
    categoryName: String,
    gunName: String
  },

  components: {
    ViewToolbar,
    GunDataCategories,
    CategoriesView,
    BrandsView,
    GunsView,
    SpecificGunItem
  },

  data: () => ({
    previous: '',
    filterByNameString: '',
  }),

  computed: {
    filteredData() {
      return this.brands.filter(x=> x.title.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
    }
  },

  mounted() {
    console.log(this.brandName);
    console.log(this.categoryName);
    console.log(this.gunName);
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
    padding:10px;
    min-height: calc(100vh - 64px);
  }

  .categoriesMenu {
    min-height: calc(100vh - 64px);
    padding-left: 30px;
  }

  .dataView {
    min-height: calc(100vh - 64px);
    padding-right: 30px;
  }
}
</style>
