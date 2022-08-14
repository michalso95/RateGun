<template>
  <div>
    <v-form ref       = "addForm"
            v-model   = "valid"
    >
      <v-card class="add-brand-card">
        <v-card-title>Dodaj Brand? Manufactuer? to to samo?</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "newBrand.name"
            label   = "Nazwa"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-textarea
            v-model="newBrand.descrGeneral"
            label="Opis Ogólny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="newBrand.descrHistory"
            label="Opis Historyczny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="newBrand.descrCuriosities"
            label="Opis Curiosities?"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-text-field
            autofocus
            v-model = "newBrand.yearEstablish"
            label   = "Rok utworzenia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newBrand.yearClose"
            label   = "Rok zamknięcia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newBrand.country"
            label   = "Kraj"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newBrand.location"
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

import {ADD_BRAND} from '../../../store/mutations';

export default {
  name:  "AddBrandForm",
  data() {
    return {
      valid:       false,
      newBrand: {
        name: '',
        descrGeneral: '',
        descrHistory: '',
        descrCuriosities: '',
        yearEstablish: 0,
        yearClose: 0,
        country: '',
        location: '',
      },
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  methods: {
    add() {
      this.$store.commit(ADD_BRAND, this.newBrand);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
  },
};
</script>

<style>
.add-brand-card{
  min-width: 450px;
  padding: 20px;
}
</style>
