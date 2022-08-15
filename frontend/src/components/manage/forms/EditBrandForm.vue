<template>
  <div>
    <v-form ref       = "editForm"
            v-model   = "valid"
    >
      <v-card class="edit-brand-card">
        <v-card-title>Edytuj markę</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "editedBrand.name"
            label   = "Nazwa"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-textarea
            v-model="editedBrand.descrGeneral"
            label="Opis Ogólny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="editedBrand.descrHistory"
            label="Opis Historyczny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="editedBrand.descrCuriosities"
            label="Opis Curiosities?"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-text-field
            autofocus
            v-model = "editedBrand.yearEstablish"
            label   = "Rok utworzenia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedBrand.yearClose"
            label   = "Rok zamknięcia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedBrand.country"
            label   = "Kraj"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedBrand.location"
            label   = "Lokalizacja"
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

import {EDIT_BRAND} from '../../../store/actions';

export default {
  name:  "EditBrandForm",
  props: {
    brand: Object
  },
  data() {
    return {
      valid:       false,
      editedBrand: undefined,
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  beforeMount(){
    this.editedBrand = JSON.parse(JSON.stringify(this.brand));
  },
  methods: {
    edit() {
      this.$store.dispatch(EDIT_BRAND, this.editedBrand);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
  },
};
</script>

<style>
.edit-brand-card{
  min-width: 450px;
  padding: 20px;
}
</style>
