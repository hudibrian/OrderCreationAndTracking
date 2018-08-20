<template>
  <div>
    <div>
      <CreateOrder></CreateOrder>
    </div>
    <div>
      <ViewOrders></ViewOrders>
    </div>
  </div>
</template>

<script>
  import CreateOrder from '@/components/CreateOrder.vue';
  import ViewOrders from '@/components/ViewOrders.vue';

  export default {
    name: 'orders',
    components: {
      CreateOrder,
      ViewOrders
    },
  };
</script>