import Vue from 'vue'
import VueRouter from 'vue-router'

import CategoriesView from '../views/CategoriesView.vue';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        redirect: '/categories'
    },
    {
        path: '/categories',
        component: CategoriesView
    }
];

const router = new VueRouter({
    mode: 'history',
    routes
});

export default router;