import Vue from 'vue';
import Vuex from 'vuex';
import VueRx from 'vue-rx';
import App from './App.vue';
import Router from './router/index';
import Store from './store/index';
import VuetifyConfiguration from './styles/vuetify-configuration';
import VHotKey from 'v-hotkey';
import Vuetify from 'vuetify';


Vue.use(Vuex);
Vue.use(VueRx);
Vue.use(Vuetify);
Vue.use(VHotKey);

new Vue({
  router: Router,
  store: Store,
  vuetify: new Vuetify(VuetifyConfiguration),
  render: createElement => createElement(App),
  el: '#app'
});

