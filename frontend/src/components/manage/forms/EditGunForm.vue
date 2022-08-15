<template>
  <div>
    <v-form ref       = "editForm"
            v-model   = "valid"
    >
      <v-card class="edit-gun-card">
        <v-card-title>Edytuj broń</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "editedGun.model"
            label   = "Model"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedGun.version"
            label   = "Wersja"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedGun.type"
            label   = "Typ (czy to kategoria?)"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedGun.manufacturer"
            label   = "Marka (czy to manufacturer==brand?)"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedGun.gunPlant"
            label   = "Producent (gun plant)"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "editedGun.bulletCal"
            label   = "Kaliber naboi"
          ></v-text-field>
          <v-text-field
            autofocus
            type = "number"
            v-model = "editedGun.magazineCapacity"
            label   = "Ilość naboi w magazynku"
          ></v-text-field>
          <v-text-field
            autofocus
            type = "number"
            v-model = "editedGun.productionBegin"
            label   = "Rok rozpoczęcia produkcji"
          ></v-text-field>
          <v-text-field
            autofocus
            type = "number"
            v-model = "editedGun.productionFinish"
            label   = "Rok zakończenia produkcji"
          ></v-text-field>
          <v-textarea
            v-model="editedGun.descrGeneral"
            label="Opis Ogólny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="editedGun.descrHistory"
            label="Opis Historyczny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="editedGun.descrCuriosities"
            label="Opis Curiosities?"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="editedGun.descrTech"
            label="Opis techniczny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <div>
            Dane techniczne:
            <v-btn icon @click.prevent="addNewTechDataItem">
              <v-icon>mdi-plus-circle</v-icon>
            </v-btn>
            <v-row v-for="techDataItem in editedGun.technicalKeyValuePairs"
              :key="techDataItem.id"
            >
              <v-col>
                <v-text-field
                  autofocus
                  v-model = "techDataItem.key"
                  label   = "Klucz"
                  outlined
                ></v-text-field>
              </v-col>
              <v-col>
                <v-text-field
                  autofocus
                  v-model = "techDataItem.value"
                  label   = "Wartość"
                  outlined
                ></v-text-field>
              </v-col>
              <v-col cols="1" align="right" class="mr-5">
                <div class="my-auto">
                    <v-btn icon @click.prevent="removeTechnicalDataPair(techDataItem.id)">
                      <v-icon>mdi-delete</v-icon>
                    </v-btn>
                  </div>
              </v-col>
            </v-row>
          </div>
          <v-textarea
            v-model="editedGun.bibliography"
            label="Bibliografia"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
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

import {EDIT_GUN} from '../../../store/actions';
import {v4 as uuidv4} from 'uuid';

export default {
  name:  "EditGunForm",
  props: {
    gun: Object
  },
  data() {
    return {
      valid:  false,
      editedGun: undefined,
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  beforeMount(){
    console.log('in mount');
    this.editedGun = JSON.parse(JSON.stringify(this.gun));
  },
  methods: {
    edit() {
      console.log(this.editedGun);
      this.$store.dispatch(EDIT_GUN, this.editedGun);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
    addNewTechDataItem(){
      this.editedGun.technicalKeyValuePairs.push({
        id: uuidv4(),
        key: '',
        value: ''
      })
    },
    removeTechnicalDataPair(id) {
      this.editedGun.technicalKeyValuePairs = this.editedGun.technicalKeyValuePairs.filter(pair => pair.id !== id);
    }
  },
};
</script>

<style>
.edit-gun-card{
  min-width: 800px;
  padding: 20px;
}
</style>
