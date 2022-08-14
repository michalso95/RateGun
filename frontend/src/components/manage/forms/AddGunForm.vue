<template>
  <div>
    <v-form ref       = "addForm"
            v-model   = "valid"
    >
      <v-card class="add-gun-card">
        <v-card-title>Dodaj broń</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "newGun.model"
            label   = "Model"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newGun.version"
            label   = "Wersja"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newGun.type"
            label   = "Typ (czy to kategoria?)"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newGun.manufacturer"
            label   = "Marka (czy to manufacturer==brand?)"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newGun.gunPlant"
            label   = "Producent (gun plant)"
          ></v-text-field>
          <v-text-field
            autofocus
            v-model = "newGun.bulletCal"
            label   = "Kaliber naboi"
          ></v-text-field>
          <v-text-field
            autofocus
            type = "number"
            v-model = "newGun.magazineCapacity"
            label   = "Ilość naboi w magazynku"
          ></v-text-field>
          <v-text-field
            autofocus
            type = "number"
            v-model = "newGun.productionBegin"
            label   = "Rok rozpoczęcia produkcji"
          ></v-text-field>
          <v-text-field
            autofocus
            type = "number"
            v-model = "newGun.productionFinish"
            label   = "Rok zakończenia produkcji"
          ></v-text-field>
          <v-textarea
            v-model="newGun.descrGeneral"
            label="Opis Ogólny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="newGun.descrHistory"
            label="Opis Historyczny"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="newGun.descrCuriosities"
            label="Opis Curiosities?"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
          ></v-textarea>
          <v-textarea
            v-model="newGun.descrTech"
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
            <v-row v-for="techDataItem in newGun.technicalKeyValuePairs"
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
            v-model="newGun.bibliography"
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

import {ADD_GUN} from '../../../store/mutations';
import {v4 as uuidv4} from 'uuid';

export default {
  name:  "AddGunForm",
  data() {
    return {
      valid:  false,
      newGun: {
        model: '',
        version: '',
        type: '',
        manufacturer: '',
        gunPlant: '',
        productionBegin: 0,
        productionFinish: 0,
        magazineCapacity: 0,
        bulletCal: '',
        descrGeneral: '',
        technicalKeyValuePairs: [{
          id: uuidv4(),
          key: '',
          value: ''
        },],
        descrTech: '',
        descrCuriosities: '',
        descrHistory: '',
        bibliography: '',
      },
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  methods: {
    add() {
      console.log(this.newGun);
      this.$store.commit(ADD_GUN, this.newGun);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
    addNewTechDataItem(){
      this.newGun.technicalKeyValuePairs.push({
        id: uuidv4(),
        key: '',
        value: ''
      })
    },
    removeTechnicalDataPair(id) {
      this.newGun.technicalKeyValuePairs = this.newGun.technicalKeyValuePairs.filter(pair => pair.id !== id);
    }
  },
};
</script>

<style>
.add-gun-card{
  min-width: 800px;
  padding: 20px;
}
</style>
