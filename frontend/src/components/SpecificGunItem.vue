<template>
  <v-card class="mx-auto" max-width="350px">
    <v-card-text>
      <div>Some data about specific gun item {{this.gunName}}</div>
    </v-card-text>>
  </v-card>
</template>

<script lang="js">


export default {
  name: "SpecificGunItem",

  props: {
    gunName: String,
  },

  data: () => ({
  }),
};
</script>

<style scoped lang="scss">

</style>
