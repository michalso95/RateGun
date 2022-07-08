import Vue from 'vue'
import VueRouter from 'vue-router'

import NewsView from '../views/NewsView.vue';
import AccountView from '../views/AccountView.vue';
import SelectorView from '../views/SelectorView.vue';
import SpecificGunItem from '../components/SpecificGunItem.vue';
import CategoriesCatalogView from '../views/CategoriesCatalogView.vue';
import BrandsCatalogView from '../views/BrandsCatalogView.vue';
import GunsCatalogView from '../views/GunsCatalogView.vue';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        redirect: '/selector/technicalData'
    },
    {
        path: '/news',
        component: NewsView
    },
    {
        path: '/brandsCatalog',
        component: BrandsCatalogView
    },
    {
        path: '/brandsCatalog/:brandName',
        component: BrandsCatalogView,
        props: true
    },
    {
        path: '/brandsCatalog/:brandName/:categoryName',
        component: BrandsCatalogView,
        props: true
    },
    {
        path: '/brandsCatalog/:brandName/:categoryName/:specificGun',
        component: SpecificGunItem,
        props: true
    },
    {
        path: '/gunsCatalog',
        component: GunsCatalogView
    },
    {
        path: '/gunsCatalog/:specificGun',
        component: SpecificGunItem,
        props: true
    },
    {
        path: '/categoriesCatalog/',
        component: CategoriesCatalogView,
        props: true
    },
    {
        path: '/categoriesCatalog/:categoryName/',
        component: CategoriesCatalogView,
        props: true
    },
    {
        path: '/categoriesCatalog/:categoryName/:brandName',
        component: CategoriesCatalogView,
        props: true
    },
    {
        path: '/categoriesCatalog/:categoryName/:brandName/:specificGun',
        component: SpecificGunItem,
        props: true
    },
    {
        path: '/user',
        component: AccountView
    },
    {
        path: '/selector',
        redirect: '/selector/technicalData'
    },
    {
        path: '/selector/:dataCategoryName/',
        component: SelectorView,
        props: true
    },
    {
        path: '/selector/:dataCategoryName/:categoryName',
        component: SelectorView,
        props: true
    },
    {
        path: '/selector/:dataCategoryName/:categoryName/:brandName',
        component: SelectorView,
        props: true
    },
    {
        path: '/selector/:dataCategoryName/:categoryName/:brandName/:gunName',
        component: SelectorView,
        props: true
    },
];

const router = new VueRouter({
    mode: 'history',
    routes
});

export default router;