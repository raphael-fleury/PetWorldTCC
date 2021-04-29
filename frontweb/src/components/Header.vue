<template>
  <header>
      <img id="logo" src="../assets/logo.png" alt="PetWorld">
      <ul id="buttons">
          <li v-for="button of buttons" :key="button.name">
              <header-button :name="button.name" :url="button.url"></header-button>
          </li>
      </ul>
  </header>
</template>

<script>
import HeaderButton from '../components/HeaderButton'

export default {

    props: [],

    components: {
        'header-button': HeaderButton
    },

    data () {
      return {
        buttons: [
            {
                name: 'Pets',
                url: '/pets'
            },
            {
                name: 'Clientes',
                url: '/clientes'
            }
        ]
    }
  }
}
</script>

<style>
    header {
        display: flex;
        flex-direction: row;
        align-items: initial;

        width: 100%;
        height: 10%;
        margin-bottom: 20px;

        background-color: #FFA400;
    }

    img {
        height: 50px;
        margin: 10px;
    }

    #buttons li {
        height: 100%;
        margin: 0px;
    }

    button {
        padding: 0px 10px;
        background-color: #FFA400;
        border: none;
        color: white;

        font-size: 16pt;
    }
</style>
