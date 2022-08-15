<template>
  <div class="brandsManagement">
    <div class="brandsManagement-form">
      <div class="mt-5">
        <div class="brandsManagement-header">
          <h2>All Brands</h2>
          <div>
            <v-btn @click.prevent="addBrandDialog = true" color="accent">
              <v-icon class="margin-right-small">mdi-plus-circle</v-icon>
              Add Brands
            </v-btn>
          </div>
        </div>
        <v-simple-table>
          <template v-slot:default>
            <thead>
              <tr>
                <th class="text-left">Brand name</th>
                <th class="text-left">Country</th>
                <th class="text-left">Location</th>
                <th class="text-left"></th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="brand in brandsList" :key="brand.id">
                <td>{{ brand.name }}</td>
                <td>{{ brand.country }}</td>
                <td>{{ brand.location }}</td>
                <td align="right">
                  <div class="my-auto">
                    <v-btn icon @click.prevent="editBrand(brand)">
                      <v-icon>mdi-pencil</v-icon>
                    </v-btn>
                    <v-btn icon @click.prevent="removeBrand(brand)">
                      <v-icon>mdi-delete</v-icon>
                    </v-btn>
                  </div>
                </td>
              </tr>
            </tbody>
          </template>
        </v-simple-table>
      </div>
    </div>
    <v-dialog v-model="addBrandDialog" max-width="500" persistent>
      <AddBrandForm
        v-if="addBrandDialog"
        @closeDialog="addBrandDialog = false"
      />
    </v-dialog>
    <v-dialog v-model="editBrandDialog" max-width="500" persistent>
      <EditBrandForm
        v-if="editBrandDialog"
        :brand="editedBrand"
        @closeDialog="editBrandDialog = false"
      />
    </v-dialog>
  </div>
</template>

<script lang="js">

import AddBrandForm from "./forms/AddBrandForm";
import EditBrandForm from "./forms/EditBrandForm";
import { mapState } from "vuex";
import { REMOVE_BRAND } from "@/store/actions";

export default {
  name: "BrandsManagementPane",
  components: {
    AddBrandForm,
    EditBrandForm,
  },
  data() {
    return {
      addBrandDialog: false,
      editBrandDialog: false,
      editedBrand: undefined,
    };
  },
  computed: {
    ...mapState({
      state: (state) => {
        return state;
      },
    }),
    brandsList() {
      return this.state.brands.all;
    }
  },
  methods: {
    async removeBrand(brand) {
      this.$store.dispatch(REMOVE_BRAND, brand);
    },
    editBrand(brand) {
      this.editedBrand = brand;
      this.editBrandDialog = true;
    }
  },
};
</script>

<style scoped lang="scss">

.brandsManagement {
  padding-top: 20px;
  width: 100%;
}

.brandsManagement-form {
  margin-left: 10px;
  padding-top: 30px;
  width: 95%;
}

.brandsManagement-form > {
  padding-top: 20px;
}

.brandsManagement-header {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  padding-bottom: 10px;
}
</style>