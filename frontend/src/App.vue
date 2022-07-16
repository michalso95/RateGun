<template>
  <v-app id="app">
    <v-app-bar dark app height="50px" class="app-bar">
      <router-link to="/" tag="div" class="logo">
        <img src="/images/logo.png" />
        <div class="ml-3 text">RATE GUN</div>
      </router-link>
      <v-spacer></v-spacer>
      <v-btn
        v-for="link in dataCategories"
        :key="link.text"
        color="white"
        text
        rounded
        class="my-2"
        :to="calculateLink(link.link)"
      >
        <v-icon>{{ link.icon }}</v-icon> {{ link.text }}
      </v-btn>

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

          <v-list-item to="/categoriesCatalog">
            <v-list-item-icon>
              <v-icon> mdi-shape </v-icon>
            </v-list-item-icon>
            <v-list-item-content> Categories </v-list-item-content>
          </v-list-item>

          <v-list-item to="/brandsCatalog">
            <v-list-item-icon>
              <v-icon> mdi-bat </v-icon>
            </v-list-item-icon>
            <v-list-item-content> Brands </v-list-item-content>
          </v-list-item>

          <v-list-item to="/gunsCatalog">
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
        <v-col class="primary lighten-2 py-4 text-center white--text" cols="12">
          2022 — <strong>RateGun @Sokolowski&Sokolowski</strong>
        </v-col>
      </v-row>
    </v-footer>
  </v-app>
</template>

<script>
import { SET_GUNS, SET_BRANDS, SET_CATEGORIES, SET_REVIEWS } from "./store/mutations";

export default {
  name: "App",

  data: () => ({
    dataCategories: [
      {
        text: "Dane techniczne",
        icon: "mdi-relative-scale",
        link: "technicalData",
      },
      {
        text: "Opinie",
        icon: "mdi-comment-quote",
        link: "reviews",
      },
      {
        text: "Amunicja",
        icon: "mdi-ammunition",
        link: "ammunition",
      },
      {
        text: "Produkcja",
        icon: "mdi-hammer-wrench",
        link: "producer",
      },
      {
        text: "Opis",
        icon: "mdi-book-open-variant",
        link: "description",
      },
      {
        text: "Galeria",
        icon: "mdi-camera",
        link: "photos",
      },
    ],
  }),

  mounted() {
    const categories = [
      {
        id: 0,
        name: "Karabiny",
        image: "/images/rifle.png",
        description: "Bla bla bla o karabinach",
        link: "rifles",
      },
      {
        id: 1,
        name: "Pistolety maszynowe",
        image: "/images/machinePistol.png",
        description: "Bla bla bla o pistoletach maszynowych",
        link: "machinePistols",
      },
      {
        id: 2,
        name: "Broń krótka",
        image: "/images/pistol.png",
        description: "Bla bla bla o broni krótkiej",
        link: "pistols",
      },
      {
        id: 3,
        name: "Karabiny wyborowe",
        image: "/images/sniper.png",
        description: "Bla bla bla o karabinach ale wyborowych",
        link: "specialRifles",
      },
      {
        id: 4,
        name: "Akcesoria",
        image: "/images/accessories.png",
        description: "Bla bla bla o akcesoriach",
        link: "accesories",
      },
      {
        id: 5,
        name: "Karabiny again",
        image: "/images/rifle.png",
        description: "Bla bla bla o tym że potrzebujemy danych",
        link: "riflesAgain",
      },
      {
        id: 6,
        name: "Pistolety again",
        image: "/images/pistol.png",
        description: "Bla bla bla o pistoletach again",
        link: "pistolsAgain",
      },
      {
        id: 7,
        name: "Inna kategoria",
        image: "/images/logo.png",
        description: "Bla bla bla o innych rzeczach",
        link: "other",
      },
    ];

    const brands = [
      {
        id: 0,
        name: "Beretta",
        description: "Jedno zdanie",
        link: "Beretta",
      },
      {
        id: 1,
        name: "CZ",
        description: "Jedno zdanie",
        link: "CZ",
      },
      {
        id: 2,
        name: "Colt",
        description: "Jedno zdanie",
        link: "Colt",
      },
      {
        id: 3,
        name: "Need",
        description: "Jedno zdanie",
        link: "Need",
      },
      {
        id: 4,
        name: "More",
        description: "Jedno zdanie",
        link: "More",
      },
      {
        id: 5,
        name: "Data",
        description: "Jedno zdanie",
        link: "Data",
      },
    ];

    const guns = [
      {
        id: 0,
        name: "Pistolet Maszynowy PM – 98",
        image: "/images/rifle.png",
        description: "Bla bla bla o Pistolet Maszynowy PM – 98",
        link: "pistoletMaszynowyPm98",
      },
      {
        id: 1,
        name: "Pistolet Maszynowy PM – 06",
        image: "/images/machinePistol.png",
        description: "Bla bla bla o Pistolet Maszynowy PM – 06",
        link: "pistoletMaszynowyPm06",
      },
      {
        id: 2,
        name: "CZ Scorpion EVO",
        image: "/images/pistol.png",
        description: "Bla bla bla o evo",
        link: "czScorpionEvo",
      },
      {
        id: 3,
        name: "CZ 512",
        image: "/images/sniper.png",
        description: "Bla bla bla o 512",
        link: "cz512",
      },
      {
        id: 4,
        name: "CZ-USA Sport",
        image: "/images/accessories.png",
        description: "Bla bla bla o sport",
        link: "czUsaSport",
      },
      {
        id: 5,
        name: "CZ Bren",
        image: "/images/rifle.png",
        description: "Bla bla bla o Bren",
        link: "czBren",
      },
    ];
    const reviews = [
      {
        id: 1,
        userName: "jakis username",
        gunName: "CZ 512",
        ratings: [
          {
            name: "Ogólny",
            type: "rateGeneral",
            points: 2,
          },
          {
            name: "Celność",
            type: "rateAccuarcy",
            points: 1.5,
          },
          {
            name: "Problematyczość",
            type: "rateFailureFree",
            points: 3,
          },
          {
            name: "Jakość materiału",
            type: "rateMaterialQuality",
            points: 3,
          },
          {
            name: "Wygląd",
            type: "rateLook",
            points: 3,
          },
          {
            name: "Ergonomia",
            type: "rateErgonomic",
            points: 3,
          },
          {
            name: "Modyfikowalność",
            type: "rateModifiable",
            points: 3,
          },
          {
            name: "Widoczność",
            type: "visibility",
            points: 3,
          },
          {
            name: "nonCompilancePoints",
            type: "nonCompilancePoints",
            points: 2
          }],
        descrRate: "Wszystko spoko, 2/10.",
        points: 100,
        publicationDate: "Dzis. Zawsze jest dzis, a jutro nie nadchodzi.",
        text: "Lorem ipsum. Bardzo fajna bron, polecam serdecznie wszystkim niezdecydowanym, bo fajnie się strzela.",
        title: "Fascynująca.",
      },
      {
        id: 2,
        userName: "inny username",
        gunName: "Beretta F92",
        ratings: [
          {
            name: "Ogólny",
            type: "rateGeneral",
            points: 5,
          },
          {
            name: "Celność",
            type: "rateAccuarcy",
            points: 5,
          },
          {
            name: "Problematyczość",
            type: "rateFailureFree",
            points: 2.5,
          },
          {
            name: "Jakość materiału",
            type: "rateMaterialQuality",
            points: 3.5,
          },
          {
            name: "Wygląd",
            type: "rateLook",
            points: 2,
          },
          {
            name: "Ergonomia",
            type: "rateErgonomic",
            points: 4,
          },
          {
            name: "Modyfikowalność",
            type: "rateModifiable",
            points: 5,
          },
          {
            name: "Widoczność",
            type: "visibility",
            points: 4,
          },
          {
            name: "nonCompilancePoints",
            type: "nonCompilancePoints",
            points: 1
          }],
        descrRate: "Wszystko spoko, 10/10. Bo Beretta to najfajniejsza",
        points: 100,
        publicationDate: "Dzis. Zawsze jest dzis, a jutro nie nadchodzi nigdy.",
        text: "Lorem ipsum. Bardzo fajna bron, polecam serdecznie wszystkim niezdecydowanym, bo fajnie się strzela. I tutaj dam troszke dluzszy opis, bo moge i mam fajna klawiature, więc pisze nie dość że szybko to jeszcze sprawia mi to przyjemnosc.",
        title: "Olśniewająca!",
      },
      {
        id: 3,
        userName: "Filip",
        gunName: "CZ nie pamiętam numeru",
        ratings: [
          {
            name: "Ogólny",
            type: "rateGeneral",
            points: 5,
          },
          {
            name: "Celność",
            type: "rateAccuarcy",
            points: 4.5,
          },
          {
            name: "Problematyczość",
            type: "rateFailureFree",
            points: 3.5,
          },
          {
            name: "Jakość materiału",
            type: "rateMaterialQuality",
            points: 2,
          },
          {
            name: "Wygląd",
            type: "rateLook",
            points: 5,
          },
          {
            name: "Ergonomia",
            type: "rateErgonomic",
            points: 4.5,
          },
          {
            name: "Modyfikowalność",
            type: "rateModifiable",
            points: 5,
          },
          {
            name: "Widoczność",
            type: "visibility",
            points: 3.5,
          },
          {
            name: "nonCompilancePoints",
            type: "nonCompilancePoints",
            points: 2.5
          }],
        descrRate: "Wszystko spoko, 2/10.",
        points: 100,
        publicationDate: "Dzis. Zawsze jest dzis, a jutro nie nadchodzi.",
        text: "Lorem ipsum. Oczywiście, że jedyna w swoim rodzaju. Co prawda nie pamiętam dokładnego modelu Twojej broni Filip, ale wiem, że CZ.",
        title: "Jedyna w swoim rodzaju?",
      },
    ];

    this.$store.commit(SET_GUNS, guns);
    this.$store.commit(SET_BRANDS, brands);
    this.$store.commit(SET_CATEGORIES, categories);
    this.$store.commit(SET_REVIEWS, reviews);
  },

  methods: {
    calculateLink(link) {
      let url = "/selector/" + link + "/";
      if (this.$route.params.categoryName)
        url += this.$route.params.categoryName + "/";
      if (this.$route.params.brandName)
        url += this.$route.params.brandName + "/";
      if (this.$route.params.gunName) url += this.$route.params.gunName + "/";
      return url;
    },
  },
};
</script>

<style lang="scss">
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

.view-container {
  min-height: calc(100vh - 64px);
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  margin-top: 30px;

  .view-toolbar {
    width: 100%;
    flex: 0px;
    max-height: 75px;
    margin-top: 30px;
    margin-bottom: 30px;
    border: 1px solid white;
    padding: 20px;
  }

  .view-content {
    width: 100%;
    flex: 1;
    overflow: hidden;
    padding-top: 30px;
    padding-bottom: 30px;
    padding: 10px;
    min-height: calc(100vh - 64px);
    margin: auto;
    margin-top: 30px;
  }
}
</style>
