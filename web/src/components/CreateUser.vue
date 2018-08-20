<template>
  <div>
    <div>
      <input v-model="user.firstName" type="text" placeholder="First Name"/>
      <input v-model="user.lastName" type="text" placeholder="Last Name"/>
    </div>
    <div>
      <button v-on:click="createUser">Create User</button>
    </div>
  </div>
</template>

<script>
export default {
  name: 'CreateUser',
  props: {
  },
  methods: {
    createUser() {
      console.log(this.user);
      fetch('https://localhost:5001/api/users', {method: 'POST', body: this.user, headers: new Headers()})
      
      .then(response => (this.info = response))
    }
  }
};
</script>
