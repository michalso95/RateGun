<template>
  <div class="mx-auto dataStyle">
    <h2 class="mb-5">{{title}}</h2>
    <v-carousel>
      <v-carousel-item
        v-for="(item, i) in photos"
        :key="i"
        :src="item.url"
        reverse-transition="fade-transition"
        transition="fade-transition"
      ></v-carousel-item>
    </v-carousel>
  </div>
</template>

<script lang="js">

export default {
  name: "GunPhotosComponent",

  props: {
    title: String,
  },

  data: () => ({
      photos: [
        {
          text: 'Photo',
          url: '/images/machinePistol.png',
        },
        {
          text: 'Foto',
          url: '/images/pistol.png',
        },
        {
          text: 'Zdjecie',
          url: '/images/rifle.png',
        },
        {
          text: 'Picture',
          url: '/images/sniper.png',
        },
        {
          text: 'Graphics',
          url: '/images/accessories.png',
        },
        {
          text: 'Galeria',
          url: '/images/sniper.png',
        }
      ]
    }),

  beforeMounted() {
    console.log('need to ask backend for photos, but maybe in background and at the first glimpse take photos from vuex')
  },
}
</script>
