<template>
  <div>
    <v-form ref       = "addForm"
            v-model   = "valid"
    >
      <v-card class="add-gunPlant-card">
        <v-card-title>Dodaj gun plant? Producenta?</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "newGunPlant.name"
            label   = "Nazwa"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-textarea
            v-model="newGunPlant.descr"
            label="Opis"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-text-field
            autofocus
            v-model = "newGunPlant.yearEstablish"
            label   = "Rok utworzenia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newGunPlant.yearClose"
            label   = "Rok zamknięcia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newGunPlant.location"
            label   = "Lokalizacja"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-switch
            autofocus
            v-model = "newGunPlant.isRunning"
            label   = "Link"
          ></v-switch>
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

import {ADD_GUN_PLANT} from '../../../store/mutations';

export default {
  name:  "AddGunPlantForm",
  data() {
    return {
      valid:       false,
      newGunPlant: {
        name: '',
        descr: '',
        location: '',
        yearEstablish: 0,
        yearClose: 0,
        isRunning: true
      },
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  methods: {
    add() {
      this.$store.commit(ADD_GUN_PLANT, this.newGunPlant);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
  },
};
</script>

<style>
.add-gunPlant-card{
  min-width: 450px;
  padding: 20px;
}
</style>
