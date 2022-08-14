<template>
  <div>
    <v-form ref       = "addForm"
            v-model   = "valid"
    >
      <v-card class="add-category-card">
        <v-card-title>Dodaj Kategorię</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "newCategory.name"
            label   = "Nazwa"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-textarea
            v-model="newCategory.description"
            label="Opis"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-text-field
            autofocus
            v-model = "newCategory.link"
            label   = "Link"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newCategory.image"
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
              @click    = "add"
              :disabled = "!valid"
            >Dodaj
            </v-btn>
          </div>
        </v-card-actions>
      </v-card>
    </v-form>
  </div>
</template>

<script>

import {ADD_CATEGORY} from '../../../store/mutations';

export default {
  name:  "AddCategoryForm",
  data() {
    return {
      valid:       false,
      newCategory: {
        name: '',
        description: '',
        link: '',
        image: '',
      },
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  methods: {
    add() {
      this.$store.commit(ADD_CATEGORY, this.newCategory);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
  },
};
</script>

<style>
.add-category-card{
  min-width: 450px;
  padding: 20px;
}
</style>
