import Vue from 'vue';
import Router from 'vue-router';
import users from './views/Users.vue';

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Create User',
      component: users,
    },
    {
      path: '/orders/:id',
      name: 'Create Orders',
      component: () => import('./views/CreateOrders.vue'),
    },
  ],
});
