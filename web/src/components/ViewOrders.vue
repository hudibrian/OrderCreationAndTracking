<template>
  <div class="padding-top-1" v-if="orders.length > 0">
    <h3>Order List</h3>
    <table class="center">
      <tr>
        <th>Name</th>
        <th>Street</th>
        <th>City</th>
        <th>State</th>
        <th>Zip Code</th>
        <th>Tracking ID</th>
      </tr>
      <tr v-for="(order, key) in orders" v-bind:key="key">
        <td>{{order.usersName}}</td>
        <td>{{order.street}}</td>
        <td>{{order.city}}</td>
        <td>{{order.state}}</td>
        <td>{{order.zipCode}}</td>
        <td>{{order.trackingID}}</td>
        <td><router-link :to="'/edit-order/' + order.trackingID">Edit Order</router-link></td>
      </tr>
    </table>
  </div>
</template>

<script>
export default {
  name: 'ViewOrders',
  data: function() {
    return {
      orders: []
    }
  },
  created: function() {
    this.getOrders();
    this.timer = setInterval(this.getOrders, 5000)
  },
  methods: {
    getOrders() {
      fetch('https://localhost:5001/api/orders/' + this.$route.params.id)
      .then(res => res.json())
      .then(json => {
        this.orders = json;
      })
      .catch(error => {
        console.log(error);
      });
    }
  }
};
</script>

<style>
  table, th, td {
    border: 1px solid black;
    border-collapse: collapse;
  }
  .padding-top-1 {
    padding-top: 1em;
  }
  .center {
    margin-left: auto;
    margin-right: auto;
  }
  .clickable {
    cursor:pointer;
    color:blue;
    text-decoration:underline;
  }
</style>
