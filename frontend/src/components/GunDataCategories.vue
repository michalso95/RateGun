<template>
  <v-sheet elevation="10" color="dark" max-height="95%">
        <v-list dense>
          <v-subheader>Categories</v-subheader>
          <v-list-item-group color="primary">
            <v-list-item
              v-for="(item, i) in dataCategories"
              :key="i"
              active-class="active"
              :to="calculateLink(item.link)"
            >
                <v-list-item-icon>
                  <v-icon v-text="item.icon"></v-icon>
                </v-list-item-icon>
                <v-list-item-content>
                  <v-list-item-title v-text="item.text"></v-list-item-title>
                </v-list-item-content>
            </v-list-item>
          </v-list-item-group>
        </v-list>
    </v-sheet>
</template>

<script lang="js">
  export default {
    name: 'GunDataCategories',

    data: () => ({
      dataCategories: [
        {
          text: 'Dane techniczne',
          icon: 'mdi-relative-scale',
          link: 'technicalData'
        },
        {
          text: 'Opinie',
          icon: 'mdi-comment-quote',
          link: 'reviews'
        },
        {
          text: 'Amunicja',
          icon: 'mdi-ammunition',
          link: 'ammunition'
        },
        {
          text: 'Produkcja',
          icon: 'mdi-hammer-wrench',
          link: 'producer'
        },
        {
          text: 'Opis',
          icon: 'mdi-book-open-variant',
          link: 'description'
        },
        {
          text: 'Galeria',
          icon: 'mdi-camera',
          link: 'photos'
        }
      ]
    }),

    methods: {
      calculateLink(link) {
        let url = '/selector/'+ link + '/';
        if(this.$route.params.categoryName)
          url += this.$route.params.categoryName + '/';
        if(this.$route.params.brandName)
          url += this.$route.params.brandName + '/';
        if(this.$route.params.gunName)
          url += this.$route.params.gunName + '/';
        return url;
      }
    }
  }

</script>

<style scoped lang="scss">
.active {
    color: beige;
}
</style>
