<template>
  <div class="hello">
    <input type="text" v-bind="name"> 
    <input type="password" v-bind="password"> 
    <input type="submit" >
    {{ msg }}
  </div>
</template>

<script>
export default {
  props: {
    msg: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
