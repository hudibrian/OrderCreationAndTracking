<template>
  <div class="padding-top-1" v-if="users.length > 0">
    <h3>User List</h3>
    <table class="center">
      <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Create Orders</th>
        <th>View & Edit Orders</th>
      </tr>
      <tr v-for="(user, key) in users" v-bind:key="key">
        <td>{{user.firstName}}</td>
        <td>{{user.lastName}}</td>
      </tr>
    </table>
  </div>
</template>

<script>
export default {
  name: 'ViewUsers',
  props: {
  },
  data: function() {
    return {
      users: []
    }
  },
  created: function() {
    this.getUsers();
    this.timer = setInterval(this.getUsers, 5000)
  },
  methods: {
    getUsers() {
      fetch('https://localhost:5001/api/users')
      .then(res => res.json())
      .then(json => {
        console.log(json);
        this.users = json;
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
</style>
