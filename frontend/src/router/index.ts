import Vue from 'vue'
import VueRouter from 'vue-router'

import CategoriesView from '../views/CategoriesView.vue';
import BrandsView from '../views/BrandsView.vue';
import GunsView from '../views/GunsView.vue';
import NewsView from '../views/NewsView.vue';
import AccountView from '../views/AccountView.vue';
import SelectorView from '../views/SelectorView.vue';
import SpecificGunItem from '../components/SpecificGunItem.vue';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        component: SelectorView,
        props: true
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
        path: '/brands/:brandName',
        component: CategoriesView,
        props: true
    },
    {
        path: '/brands/:brandName/:categoryName',
        component: GunsView,
        props: true
    },
    {
        path: '/brands/:brandName/:categoryName/:specificGun',
        component: SpecificGunItem,
        props: true
    },
    {
        path: '/guns',
        component: GunsView
    },
    {
        path: '/guns/:specificGun',
        component: SpecificGunItem,
        props: true
    },
    {
        path: '/categories',
        component: CategoriesView
    },
    {
        path: '/categories/:categoryName',
        component: BrandsView,
        props: true
    },
    {
        path: '/categories/:categoryName/:brandName',
        component: GunsView,
        props: true
    },
    {
        path: '/categories/:categoryName/:brandName/:specificGun',
        component: SpecificGunItem,
        props: true
    },
    {
        path: '/user',
        component: AccountView
    },
    {
        path: '/:categoryName',
        component: SelectorView,
        props: true
    },
    {
        path: '/:categoryName/:brandName',
        component: SelectorView,
        props: true
    },
    {
        path: '/:categoryName/:brandName/:gunName',
        component: SelectorView,
        props: true
    },
];

const router = new VueRouter({
    mode: 'history',
    routes
});

export default router;