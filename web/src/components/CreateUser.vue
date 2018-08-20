<template>
  <div>
    <h3>Create a User</h3>
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
  data: function() {
    return {
        user: {
          firstName: '',
          lastName: ''
      }
    }
  },
  methods: {
    createUser() {
      let fetchData = { 
        method: 'POST', 
        body: JSON.stringify(this.user),
        headers: new Headers({'Content-Type': 'application/json'})
      }
      fetch('https://localhost:5001/api/users', fetchData)
      .then(res => {
        alert('User added');
      })
      .catch(error => {
        console.log(error);
      });
    }
  }
};
</script>
