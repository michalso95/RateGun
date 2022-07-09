<template>
  <div class="mx-auto dataStyle">
    <h2>{{title}}</h2>
    <v-card >
      <v-tabs
        v-model="tab"
        background-color="transparent"
        color="white"
        grow
        dark
      >
        <v-tab
          v-for="item in items"
          :key="item.name"
        >
          {{ item.name }}
        </v-tab>
      </v-tabs>

      <v-tabs-items v-model="tab">
        <v-tab-item
          v-for="item in items"
          :key="item.name"
        >
          <v-card
            flat
          >
            <v-card-text>{{ item.value }}</v-card-text>
          </v-card>
        </v-tab-item>
      </v-tabs-items>
    </v-card>
  </div>
</template>

<script lang="js">

export default {
  name: 'GunDescriptionComponent',

  props: {
    generalDescription: String,
    technicalDescription: String,
    curiositiesDescription: String,
    historicalDescription: String,
    title: String,
  },

  data () {
      return {
        tab: null,
        items: [
          {
            name: 'Ogólny',
            value: this.generalDescription
          },
          {
            name: 'Techniczny',
            value: this.technicalDescription
          },
          {
            name: 'Ciekawostki',
            value: this.curiositiesDescription
          },
          {
            name: 'Historia',
            value: this.historicalDescription
          },
        ],
      }
    },

}
</script>

<style scoped lang="scss">

.active {
    color: beige;
}

</style>

