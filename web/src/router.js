import Vue from 'vue';
import Router from 'vue-router';
import users from './views/Users.vue';
import EditOrders from './views/EditOrders.vue';
import Orders from './views/Orders.vue';

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
      component: Orders,
    },
    {
      path: '/edit-order/:id',
      name: 'Edit Order',
      component: EditOrders,
    },
  ],
});
