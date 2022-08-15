<template>
  <div>
    <v-form ref       = "editForm"
            v-model   = "valid"
    >
      <v-card class="edit-gunPlant-card">
        <v-card-title>Edytuj gun plant? Producenta?</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "editedGunPlant.name"
            label   = "Nazwa"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-textarea
            v-model="editedGunPlant.descr"
            label="Opis"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-text-field
            autofocus
            v-model = "editedGunPlant.yearEstablish"
            label   = "Rok utworzenia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedGunPlant.yearClose"
            label   = "Rok zamknięcia"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedGunPlant.location"
            label   = "Lokalizacja"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-switch
            autofocus
            v-model = "editedGunPlant.isRunning"
            label   = "Działająca?"
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

import {EDIT_GUN_PLANT} from '../../../store/actions';

export default {
  name:  "EditGunPlantForm",
  props: {
    gunPlant: Object
  },
  data() {
    return {
      valid:       false,
      editedGunPlant: undefined,
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  beforeMount(){
    this.editedGunPlant = JSON.parse(JSON.stringify(this.gunPlant));
  },
  methods: {
    edit() {
      this.$store.dispatch(EDIT_GUN_PLANT, this.editedGunPlant);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
  },
};
</script>

<style>
.edit-gunPlant-card{
  min-width: 450px;
  padding: 20px;
}
</style>
