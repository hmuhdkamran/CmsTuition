<template>
  <div class="hello">
    <span>Enter First Value : </span>
    <input type="text" v-model="firstValue" /> <br /> <br />
    <span>Enter Second Value : </span>
    <input type="text" v-model="secondValue" /> <br /> <br /> <br />

    <button @click="calculate()">Calculate</button><br /> <br />

    <h1>Result: {{ result }}</h1>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue'

export default defineComponent({
  name: 'HelloWorld',
  props: {
    msg: String
  },
  setup () {
    const firstValue = ref(0)
    const secondValue = ref(0)
    const result = ref(0)

    const calculate = () => {
      result.value = Number(firstValue.value) + Number(secondValue.value)
      console.log(result.value)
    }

    return {
      firstValue,
      secondValue,
      result,
      calculate
    }
  }
})
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="scss">
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
