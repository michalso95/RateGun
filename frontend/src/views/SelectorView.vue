<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <div class="view-content">
        <v-row>
          <v-col cols="2">
            <GunDataCategories class="categoriesMenu" />
          </v-col>
          <v-col>
            <h2>Tu w sumie przydałby się jakiś tytuł...</h2>
            <v-breadcrumbs :items="breadcrumbs">
              <template v-slot:item="{ item }">
                <v-breadcrumbs-item :href="item.href" :disabled="item.disabled">
                  <v-btn rounded small>{{ item.text }}</v-btn>
                </v-breadcrumbs-item>
              </template>
            </v-breadcrumbs>

            <SpecificGunItem
              v-if="this.categoryName && this.brandName && this.gunName"
              :gunName="gunName"
              :dataCategoryName="dataCategoryName"
            />
            <CatalogComponent v-else :filteredData="catalogData" />
          </v-col>
        </v-row>
      </div>
    </v-sheet>
  </div>
</template>

<script lang="js">
import {mapState} from 'vuex';
import GunDataCategories from '../components/GunDataCategories.vue';
import SpecificGunItem from '../components/SpecificGunItem.vue';
import CatalogComponent from '../components/CatalogComponent.vue';

export default {
  name: "SelectorView",

  props: {
    brandName: String,
    categoryName: String,
    gunName: String,
    dataCategoryName: String,
  },

  components: {
    GunDataCategories,
    SpecificGunItem,
    CatalogComponent
  },

  data: () => ({
    filterByNameString: '',
    breadcrumbs: [],
  }),

  computed: {
    ...mapState({
      state: state => {
        return state;
      },
    }),
    catalogData() {
      if (this.categoryName && this.brandName) {
        return this.state.guns.all.filter(x=> x.name.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
      }
      else if (this.categoryName) {
        return this.state.brands.all.filter(x=> x.name.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
      }
      else {
        return this.state.categories.all.filter(x=> x.name.toLowerCase().startsWith(this.filterByNameString.toLowerCase()));
      }
    },
    gunObject() {
      return this.state.guns.all.find(x => x.name == this.gunName);
    }
  },

  watch: {
    catalogData() {
      this.prepareBreadcrumbs();
    },
    gunName() {
      this.prepareBreadcrumbs();
    },
    dataCategoryName() {
      this.prepareBreadcrumbs();
    }
  },

  mounted() {
    this.prepareBreadcrumbs();
  },

  methods: {
    filterByName(input) {
      this.filterByNameString = input;
    },
    prepareBreadcrumbs() {
      this.breadcrumbs = [];

      if(this.$route.params.dataCategoryName) {
        this.breadcrumbs.push({
          text: this.$route.params.dataCategoryName,
          disabled: false,
          href: '/selector/'
            + this.$route.params.dataCategoryName
        });
      }
      if(this.$route.params.categoryName) {
        this.breadcrumbs.push({
          text: this.$route.params.categoryName,
          disabled: false,
          href: '/selector/'
            + this.$route.params.dataCategoryName + '/'
            + this.$route.params.categoryName + '/'
        });
      }
      if(this.$route.params.brandName) {
        this.breadcrumbs.push({
          text: this.$route.params.brandName,
          disabled: false,
          href: '/selector/'
            + this.$route.params.dataCategoryName + '/'
            + this.$route.params.categoryName + '/'
            + this.$route.params.brandName + '/'
        });
      }
      if(this.$route.params.gunName) {
        this.breadcrumbs.push({
          text: this.$route.params.gunName,
          disabled: true,
        });
      }
      this.breadcrumbs[this.breadcrumbs.length - 1].disabled = true;
    }
  },


};
</script>
