<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <v-breadcrumbs :items="breadcrumbs">
        <template v-slot:divider>
          <v-icon>mdi-forward</v-icon>
        </template>
      </v-breadcrumbs>

      <div class="view-content">
        <v-row>
          <v-col cols="2">
            <GunDataCategories class="categoriesMenu" />
          </v-col>
          <v-col>
            <SpecificGunItem
              v-if="this.categoryName && this.brandName && !this.gunName"
            />
            <CatalogComponent
              v-else
              :catalogDataFor="catalogData"
            />
          </v-col>
        </v-row>
      </div>
    </v-sheet>
  </div>
</template>

<script lang="js">
import GunDataCategories from '../components/GunDataCategories.vue';
import SpecificGunItem from '../components/SpecificGunItem.vue';
import CatalogComponent from '../components/CatalogComponent.vue';

export default {
  name: "SelectorView",

  props: {
    brandName: String,
    categoryName: String,
    gunName: String
  },

  components: {
    GunDataCategories,
    SpecificGunItem,
    CatalogComponent
  },

  data: () => ({
    previous: '',
    filterByNameString: '',
    breadcrumbs: [],
  }),

  computed: {
    catalogData() {
      if (!this.categoryName && !this.brandName && !this.gunName)
        return 'category';
      else if (this.categoryName && !this.brandName && !this.gunName)
        return 'brands';
      else if (this.categoryName && this.brandName && !this.gunName)
        return 'guns';
      else if (this.categoryName && this.brandName && !this.gunName)
        return this.gunName;
      else
        return '';
    }
  },

  mounted() {
    this.breadcrumbs.push({
      title: this.categoryName,
      disabled: false,
      href: '/selector/'+this.categoryName
    });
    this.breadcrumbs.push({
      title: this.brandName,
      disabled: false,
      href: '/selector/'+this.brandName
    });
    this.breadcrumbs.push({
      title: this.gunName,
      disabled: false,
      href: '/selector/'+this.gunName
    });

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
    padding: 10px;
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
