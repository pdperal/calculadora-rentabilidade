<template>
<p> teste </p> 
  <div class="components-wrapper">
    <InvestimentoInicial/>
    <Rentabilidade/>
  </div>  

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
@import url('https://fonts.googleapis.com/css2?family=Roboto&display=swap');

#app {
  font-family: 'Roboto', sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  background-color: #eedfcc;
  font-size: 16px;
}
</style>
