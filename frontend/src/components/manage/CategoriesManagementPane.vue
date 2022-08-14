<template>
  <div class="categoriesManagement">
    <div class="categoriesManagement-form">
      <div class="mt-5">
        <div class="categoriesManagement-header">
          <h2>All Categories</h2>
          <div>
            <v-btn @click.prevent="addCategoryDialog = true" color="accent">
              <v-icon class="margin-right-small">mdi-plus-circle</v-icon>
              Add Category
            </v-btn>
          </div>
        </div>
        <v-simple-table>
          <template v-slot:default>
            <thead>
              <tr>
                <th class="text-left">Category name</th>
                <th class="text-left">Link</th>
                <th class="text-left"></th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="category in categoriesList" :key="category.id">
                <td>{{ category.name }}</td>
                <td>{{ category.link }}</td>
                <td align="right">
                  <div class="my-auto">
                    <v-btn icon @click.prevent="editCategory(category)">
                      <v-icon>mdi-pencil</v-icon>
                    </v-btn>
                    <v-btn icon @click.prevent="removeCategory(category)">
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
    <v-dialog v-model="addCategoryDialog" max-width="500" persistent>
      <AddCategoryForm
        v-if="addCategoryDialog"
        @closeDialog="addCategoryDialog = false"
      />
    </v-dialog>
    <v-dialog v-model="editCategoryDialog" max-width="500" persistent>
      <EditCategoryForm
        v-if="editCategoryDialog"
        :category="editedCategory"
        @closeDialog="editCategoryialog = false"
      />
    </v-dialog>
  </div>
</template>

<script lang="js">

import AddCategoryForm from "./forms/AddCategoryForm";
import EditCategoryForm from "./forms/EditCategoryForm";
import { mapState } from "vuex";
import { REMOVE_CATEGORY } from "@/store/actions";

export default {
  name: "CategorysManagementPane",
  components: {
    AddCategoryForm,
    EditCategoryForm,
  },
  data() {
    return {
      addCategoryDialog: false,
      editCategoryDialog: false,
      editedCategory: undefined,
    };
  },
  computed: {
    ...mapState({
      state: (state) => {
        return state;
      },
    }),
    categoriesList() {
      return this.state.categories.all;
    }
  },
  methods: {
    async removeCategory(category) {
      this.$store.dispatch(REMOVE_CATEGORY, category);
    },
    editCategory(category) {
      this.editedCategory = category;
      this.editCategoryDialog = true;
    }
  },
};
</script>

<style scoped lang="scss">

.categoriesManagement {
  padding-top: 20px;
  width: 100%;
}

.categoriesManagement-form {
  margin-left: 10px;
  padding-top: 30px;
  width: 95%;
}

.categoriesManagement-form > {
  padding-top: 20px;
}

.categoriesManagement-header {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  padding-bottom: 10px;
}
</style>