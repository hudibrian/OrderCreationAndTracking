<template>
  <div>
    <div>
      <h3>Modify any field and click Update Order to continue</h3>
      <div>
        <input v-model="order.trackingID" type="text" disabled placeholder="Tracking ID"/>
        <input v-model="order.usersName" type="text" placeholder="Name"/></div>
      <div>
        <input v-model="order.street" type="text" placeholder="Street"/>
        <input v-model="order.city" type="text" placeholder="City"/>
      </div>
      <div>
        <input v-model="order.state" type="text" placeholder="State"/>
        <input v-model="order.zipCode" type="text" placeholder="Zip Code"/>
      </div>
    </div>
    <div>
      <button v-on:click="$router.go(-1)">Back</button>
      <button v-on:click="createOrder();">Update Order</button>
    </div>
  </div>
</template>

<script>
export default {
  name: 'EditOrder',
  data: function() {
    return {
        order: {
          usersName: '',
          street: '',
          city: '',
          state: '',
          zipCode: '',
          trackingId: '',
          user: {}
      }
    }
  },
  created: function() {
      this.setOrder();
  },
  methods: {
    createOrder() {
      console.log(this.order);
      let fetchData = { 
        method: 'PUT', 
        body: JSON.stringify(this.order),
        headers: new Headers({'Content-Type': 'application/json'})
      }
      fetch('https://localhost:5001/api/orders', fetchData)
      .then(res => {
        alert('Order updated');
        history.back()
      })
      .catch(error => {
        console.log(error);
      });
    },

    setOrder() {
      fetch('https://localhost:5001/api/orders/get/' + this.$route.params.id)
        .then(res => res.json())
        .then(json => {
          this.order = json;
        })
    }
  }
};
</script>
