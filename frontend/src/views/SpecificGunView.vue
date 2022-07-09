<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <div class="view-content">
        <SpecificGunItem />
      </div>
    </v-sheet>
  </div>
</template>

<script>
import SpecificGunItem from '../components/SpecificGunItem.vue'

export default {
  name: "SpecificGunView",

  components: {
    SpecificGunItem
  },

  data: () => ({
    //
  }),
};
</script>

