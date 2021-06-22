<template>
  <div class="investimento-field">
    <p> Informe o investimento inicial: </p>
    <input placeholder="Investimento inicial">
  </div>
</template>

<script>
export default {
  name: "Field",
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
    border-radius: 3px;
    border: 1px solid #e3e3e3;
    float: left;
    margin: 10px;
    padding: 10px;
    width: 190px;
    top: 100px;
    height: 10px;
  }   
  p {
    text-align: left;
    margin: 0px;
    padding: 10px;
    display: flex;
    height: 10px;
  }   
</style>
