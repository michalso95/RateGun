<template>
  <div class="mx-auto">
    <v-card class="mx-auto mt-5" min-width="100%" elevation="5">
      <v-row>
        <v-card-title>
          {{ review.title }} <br/>
          {{ review.gunName }}
        </v-card-title>
      </v-row>
      <v-row>
        <v-col cols="5" class="pl-5">
          <v-row v-for="rate in review.ratings" :key="rate.name">
            <v-col> {{ rate.name }}: </v-col>
            <v-col>
              <v-rating
                :value="rate.points"
                background-color="#F6F6F6"
                color="#F2DF3A"
                half-increments
                hover
                length="5"
                readonly
              ></v-rating>
            </v-col>
          </v-row>
        </v-col>
        <v-col>
          <v-card-subtitle>
            {{ review.text }}
          </v-card-subtitle>
        </v-col>
      </v-row>
      <v-row>
        <v-spacer></v-spacer>
        <v-card-subtitle class="text-right">
          Posted by {{review.userName}}. <br/>
          Date: {{review.publicationDate}} <br/>
          {{new Date().toJSON().slice(0,10).replace(/-/g,'/')}}
        </v-card-subtitle>
      </v-row>
    </v-card>
  </div>
</template>

<script lang="js">

export default {
  name: "GunReviewItem",

  props: {
    review: Object
  },
}
</script>
