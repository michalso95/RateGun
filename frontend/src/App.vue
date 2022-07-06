<template>
  <v-app id="app">
    <v-app-bar dark app height="50px" class="app-bar">
      <div class="logo">
        <img src="images/logo.png" />
        <div class="ml-3 text">RATE GUN</div>
      </div>

      <v-spacer></v-spacer>

      <v-btn icon to="/user">
        <v-icon>mdi-account</v-icon>
      </v-btn>

      <v-menu offset-y left class="menu">
        <template v-slot:activator="{ on, attrs }">
          <v-btn icon v-bind="attrs" v-on="on">
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn>
        </template>

        <v-list>
          <v-list-item to="/news">
            <v-list-item-icon>
              <v-icon> mdi-newspaper </v-icon>
            </v-list-item-icon>
            <v-list-item-content> News </v-list-item-content>
          </v-list-item>

          <v-list-item to="/categories">
            <v-list-item-icon>
              <v-icon> mdi-shape </v-icon>
            </v-list-item-icon>
            <v-list-item-content> Categories </v-list-item-content>
          </v-list-item>

          <v-list-item to="/brands">
            <v-list-item-icon>
              <v-icon> mdi-bat </v-icon>
            </v-list-item-icon>
            <v-list-item-content> Brands </v-list-item-content>
          </v-list-item>

          <v-list-item to="/guns">
            <v-list-item-icon>
              <v-icon> mdi-pistol </v-icon>
            </v-list-item-icon>
            <v-list-item-content> All guns </v-list-item-content>
          </v-list-item>
        </v-list>
      </v-menu>
    </v-app-bar>

    <v-main class="main-container">
      <router-view> </router-view>
    </v-main>

    <v-footer padless>
      <v-row justify="center" no-gutters>
        <v-btn
          v-for="link in dataCategories"
          :key="link.text"
          color="white"
          text
          rounded
          class="my-2"
          :to="'/data/' + link.link"
        >
          <v-icon>{{link.icon}}</v-icon> {{link.text}}
        </v-btn>
        <v-col class="primary lighten-2 py-4 text-center white--text" cols="12">
          2022 — <strong>RateGun @Sokolowski&Sokolowski</strong>
        </v-col>
      </v-row>
    </v-footer>
  </v-app>
</template>

<script>
export default {
  name: "App",

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
};
</script>

<style scoped lang="scss">
.logo {
  display: flex;
  flex-direction: row;
  cursor: default;

  img {
    height: 40px;
  }

  .text {
    font-size: 32px;
    line-height: 40px;
    letter-spacing: 3px;
  }
}
.app-bar {
  padding: 0px 50px;
}
</style>
