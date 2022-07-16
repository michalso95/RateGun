<template>
  <v-card class="mx-auto">
    <h2 class="ml-8"> {{gunName}} </h2>
    <GunDataTableComponent :tableData="technical" title="Dane techniczne" class="dataStyle" />
    <GunDataTableComponent :tableData="ammunition" title="Dane o amunicji" class="dataStyle" />
    <GunDataTableComponent :tableData="manufacturer" title="Producent" class="dataStyle" />
    <GunDescriptionComponent
      :generalDescription="generalDescr"
      :technicalDescription="techDescr"
      :curiositiesDescription="curiositiesDescr"
      :historicalDescription="historyDescr"
      title="Opis" />
    <GunPhotosComponent title="Zdjecia" class="dataStyle"/>
    <GunReviewsComponent title="Poki co wszystkie reviewsy" />
  </v-card>
</template>

<script lang="js">

import GunDataTableComponent from './gunData/GunDataTableComponent';
import GunDescriptionComponent from './gunData/GunDescriptionComponent';
import GunPhotosComponent from './gunData/GunPhotosComponent';
import GunReviewsComponent from './gunData/GunReviewsComponent';

export default {
  name: "SpecificGunItem",

  components: {
    GunDataTableComponent,
    GunDescriptionComponent,
    GunPhotosComponent,
    GunReviewsComponent
  },

  data: () => ({
    technical: [
      {
        key: 'Długość z kolbą złożoną',
        value: '400 mm'
      },
      {
        key: 'Długość z kolbą wysuniętą',
        value: '450 mm'
      },
      {
        key: 'Szerokość',
        value: '58 mm'
      },
      {
        key: 'Długość lufy',
        value: '180 mm'
      },
      {
        key: 'Długość linii celowniczej',
        value: '280 mm'
      },
      {
        key: 'Masa bez magazynka',
        value: '2300 g'
      },
      {
        key: 'Masa z magazynkiem (15)',
        value: '2590 g'
      },
      {
        key: 'Rodzaj ognia',
        value: 'pojedynczy, automatyczny'
      },
      {
        key: 'Taktyczny zasięg rażenia',
        value: '150 m'
      },
      {
        key: 'Szybkostrzelność teoretyczna',
        value: '640 strz./min'
      },
      {
        key: 'Zasada działania',
        value: 'Odrzut zamka swobodnego'
      },
    ],
    ammunition: [
      {
        key: 'Kaliber',
        value: '9 x 19 mm'
      },
      {
        key: 'Typ',
        value: 'Parabellum'
      },
      {
        key: 'Prędkość wylotowa pocisku',
        value: '360 m/s'
      },
      {
        key: 'Energia wylotowa pocisku',
        value: '518 J'
      },
    ],
    manufacturer: [
      {
        key: 'Producent',
        value: 'Jakiś tam'
      },
      {
        key: 'Rok założenia',
        value: '1000 p.n.e.'
      },
      {
        key: 'Siedziba',
        value: 'Radom, Polska'
      },
    ],
    generalDescr: 'Blablabla Opis ogólny, niech sobie będzie tak na chociaż kilka zdań, żeby było widać, że jest, a nie że go nie ma',
    techDescr: 'Blablabla Opis TECHNICZNY, niech sobie będzie tak na chociaż kilka zdań, żeby było widać, że jest, a nie że go nie ma',
    curiositiesDescr: 'Blablabla Opis CIEKAWOSTKI, niech sobie będzie tak na chociaż kilka zdań, żeby było widać, że jest, a nie że go nie ma',
    historyDescr: 'Blablabla Opis HISTORIA, niech sobie będzie tak na chociaż kilka zdań, żeby było widać, że jest, a nie że go nie ma',
  }),

  computed: {
    dataCategoryName() {
      return this.$route.params.dataCategoryName;
    },
    gunName() {
      return this.$route.params.gunName;
    }
  },
};
</script>

<style lang="scss">

.dataStyle{
  width: 90%;
  padding: 20px;
  margin-top: 30px;
  margin-bottom: 70px;
  padding-bottom: 20px;
}

</style>
