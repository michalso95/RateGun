declare module '*.vue' {
    import Vue from 'vue'
    export default Vue
}

declare module 'v-hotkey' {
    import { PluginObject } from "vue";

    const VueHotKey: PluginObject<Map<string, number>>;
    export default VueHotKey;
}