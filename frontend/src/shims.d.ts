/* vue */
declare module '*.vue' {
  import Vue from 'vue'
  export default Vue
}

/* v-hotkey */
declare module 'v-hotkey' {
  import { PluginObject } from "vue";

  // options: alias map
  const VueHotkey: PluginObject<Map<string, number>>;
  export default VueHotkey;
}

/* vue-virtual-scroller */
declare module 'vue-virtual-scroller';