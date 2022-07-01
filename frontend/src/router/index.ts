import Vue from 'vue'
import VueRouter from 'vue-router'

import CategoriesView from '../views/CategoriesView.vue';
import BrandsView from '../views/BrandsView.vue';
import GunsView from '../views/GunsView.vue';
import NewsView from '../views/NewsView.vue';
import AccountView from '../views/AccountView.vue';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        redirect: '/news'
    },
    {
        path: '/news',
        component: NewsView
    },
    {
        path: '/brands',
        component: BrandsView
    },
    {
        path: '/guns',
        component: GunsView
    },
    {
        path: '/user',
        component: AccountView
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