<template>
  <div>
    <Field/>
    <img alt="Vue logo" src="./assets/logo.png">
  </div>  
</template>

<script>
import Field from  './components/InvestimentoField.vue'

export default {
  name: 'App',
  components: {
    Field
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  background-color: #eedfcc;
  /* margin-top: 60px; */
}
</style>
