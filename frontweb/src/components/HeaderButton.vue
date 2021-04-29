<template>
  <button v-on:click="redirect(url)">{{ name }}</button>
</template>

<script>
import config from '../config';

export default {

    props: ['name', 'url', 'enabled'],

    data () {
      return {
        name: '',
        url: '',
        enabled: true,
        redirect() {
            console.log(config.apiPath + url);
        }
      }
    }
}
</script>

<style>
    button {
        height: 100%;
        margin-right: 10px;

        background-color: #FFA400;
        border: none;
        color: white;

        font-size: 16pt;
    }
</style>
