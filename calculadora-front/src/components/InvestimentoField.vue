<template>
  <div class="investimento-field">
    <p> Informe o investimento inicial: </p>
    <input 
     v-money="money"
         onfocus="this.placeholder=''" 
         onblur="this.placeholder='R$ 1.500,00'" 
         placeholder="R$ 1.500,00">
  </div>
</template>

<script>
import {VMoney} from 'v-money'

export default {
  name: "Investimento",
  data () {
      return {
        money: {
          decimal: ',',
          thousands: '.',
          prefix: 'R$ ',
          suffix: '',
          precision: 2,
          masked: false
        }
      }
    },
  directives: {money: VMoney}
}
</script>
<style scoped>
   .investimento-field {
    padding: 10px;
    border-radius: 10px;
    border: solid #e3e3e3;    
    height: 80px;
    float:left;
    display: table-row;
    top: 250px;
    margin-top: 30px;
    margin-left: 10px;
    background-color: white;
  }
   input {  
    border-radius: 5px;
    border: 1px solid #e3e3e3;
    float: left;
    margin: 15px 0px 0px 0px;
    padding: 10px;
    width: 190px;
    height: 10px;    
    /* -webkit-transition: 0.3s; */
    transition: 0.3s;
    outline: none;
  }   
  input:focus {
  border: 1px solid black;
}

  p {
    text-align: left;
    margin: 0px;
    padding: 0px 0px 14px 0px;
    display: flex;
    height: 10px;
    border-bottom: 0.100rem solid #ebebeb;
  }   
</style>
