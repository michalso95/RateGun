<template>
  <div>
    <v-form ref       = "addForm"
            v-model   = "valid"
    >
      <v-card class="add-review-card">
        <v-card-title>Dodaj opinię</v-card-title>
        <v-card-text>
          <v-text-field
            autofocus
            v-model = "newReview.title"
            label   = "Tytuł"
            :rules  = "[rules.required]"
          ></v-text-field>
          <v-textarea
            v-model="newReview.text"
            label="Opis"
            outlined
            clearable
            counter
            maxlength="512"
            full-width
            :rules  = "[rules.required]"
          ></v-textarea>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Ogólna </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateGeneral"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Accuracy </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateAccuarcy"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Default aiming </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateDefaultAiming"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Bezawaryjność </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateFailureFree"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Jakość wykonania </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateMaterialQuality"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Wygląd </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateLook"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Ergonomia </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateErgonomic"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Dostępność dodatków </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.ratePartsAddsAvailability"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
          <v-row class="mt-3 mx-auto">
            <span class="my-auto"> Modyfikowalność </span>
            <v-spacer></v-spacer>
            <v-rating
              v-model="newReview.rateModifiable"
              background-color="#F6F6F6"
              color="#F2DF3A"
              half-increments
              hover
              length="5"
            ></v-rating>
          </v-row>
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
            >Dodaj opinie
            </v-btn>
          </div>
        </v-card-actions>
      </v-card>
    </v-form>
  </div>
</template>

<script>

import {ADD_REVIEW} from '../../store/mutations';

export default {
  name:  "AddReviewForm",
  data() {
    return {
      valid:       false,
      newReview: {
        title: 'Tytuł',
        text: 'Opis',
        rateGeneral: 0,
        rateAccuarcy: 0,
        rateDefaultAiming: 0,
        rateFailureFree: 0,
        rateMaterialQuality: 0,
        rateLook: 0,
        rateErgonomic: 0,
        ratePartsAddsAvailability: 0,
        rateModifiable: 0,
      },
      rules: {
        required: (value) => !!value || "Required",
      },
    };
  },
  methods: {
    add() {
      this.$store.commit(ADD_REVIEW, this.newReview);
      this.$emit('closeDialog')
    },
    cancel() {
      this.$emit("closeDialog");
    },
  },
};
</script>

<style>
.add-review-card{
  min-width: 450px;
  padding: 20px;
}
</style>
