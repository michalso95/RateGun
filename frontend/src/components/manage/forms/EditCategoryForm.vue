<template>
  <div>
    <v-form ref       = "editForm"
            v-model   = "valid"
    >
      <v-card class="edit-category-card">
        <v-card-title>Edytuj Kategorię</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "editedCategory.name"
            label   = "Nazwa"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-textarea
            v-model="editedCategory.description"
            label="Opis"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-text-field
            autofocus
            v-model = "editedCategory.link"
            label   = "Link"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedCategory.image"
            label   = "Url zdjęcia"
            :rules  = "[rules.required]"
          ></v-text-field>
        </v-card-text>
        <v-spacer></v-spacer>
        <v-card-actions>
          <div class = "row row--end">
            <v-btn text
                   @click    = "cancel"
            >Anuluj
            </v-btn>
            <v-btn
              text
              color     = "accent"
              @click    = "edit"
              :disabled = "!valid"
            >Edytuj
            </v-btn>
          </div>
        </v-card-actions>
      </v-card>
    </v-form>
  </div>
</template>

<script>

import {EDIT_CATEGORY} from '../../../store/actions';

export default {
  name:  "EditCategoryForm",
  props: {
    category: Object
  },
  data() {
    return {
      valid:       false,
      editedCategory: undefined,
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  beforeMount(){
    this.editedCategory = JSON.parse(JSON.stringify(this.category));
  },
  methods: {
    edit() {
      this.$store.dispatch(EDIT_CATEGORY, this.editedCategory);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
  },
};
</script>

<style>
.edit-category-card{
  min-width: 450px;
  padding: 20px;
}
</style>
