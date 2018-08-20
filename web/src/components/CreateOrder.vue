<template>
  <div class="hello">
    <div>
      <h3>Please enter a tracking id and address</h3>
      <div>
        <input type="text" placeholder="Tracking ID"/>
        <input type="text" placeholder="Name"/></div>
      <div>
        <input type="text" placeholder="Street"/>
        <input type="text" placeholder="City"/>
      </div>
      <div>
        <input type="text" placeholder="State"/>
        <input type="text" placeholder="Zip Code"/>
      </div>
    </div>
    <div class="hello">
      <button>Create Order</button>
    </div>
  </div>

</template>

<script>
export default {
  name: 'CreateOrder',
  props: {
    msg: String,
  },
};
</script>
