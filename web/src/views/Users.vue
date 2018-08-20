<template>
<div>
  <div>
    <CreateUser/>
  </div>
  <div>
    <ViewUsers></ViewUsers>
  </div>
</div>
</template>

<script>
import CreateUser from '@/components/CreateUser.vue';
import ViewUsers from '@/components/ViewUsers.vue';

export default {
  name: 'users',
  components: {
    CreateUser,
    ViewUsers
  },
};
</script>
