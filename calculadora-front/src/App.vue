<template>
  <div class="mydiv">
    <p> teste </p>
    <InvestimentoInicial/>
    <Rentabilidade/>

<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
    <p> teste </p>
    <!-- <img alt="Vue logo" src="./assets/logo.png"> -->
  </div>  
</template>

<script>
import InvestimentoInicial from  './components/InvestimentoField.vue'
import Rentabilidade from  './components/Rentabilidade.vue'

export default {
  name: 'App',
  components: {
    InvestimentoInicial,
    Rentabilidade
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
}
</style>
