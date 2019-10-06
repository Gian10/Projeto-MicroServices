<template>
  <div id="app">

    <nav>
      <div class="nav-wrapper blue darken-1">
        <a href="#" class="brand-logo center"> CineMicroservice - Bilheteria</a>
      </div>
    </nav>

    <div class="container">


      <table>

        <thead>

          <tr>
            <th>Ano</th>
            <th>Filme</th>
            <th>Bilheteria R$</th>
          </tr>      

        </thead>
        

        <tbody>
          

          <tr v-for="bilheterias of bilheterias" :key="bilheterias.id">

            <td>{{bilheterias.Ano}}</td>
            <td>{{bilheterias.Nome}} </td>
            <td>{{bilheterias.Valor}} </td>

          </tr>
          <br>
        <!-- <button class="waves-effect waves-light btn-small">Filmes em Lançamento</button> -->
        <router-link to="/" class="waves-effect waves-light btn-small" tag="button">Voltar para Filmes em Cartaz</router-link>
        </tbody>
      
      </table>

    </div>

  </div>
</template>


<script>
//import Filme from './services/filmes'
import Bilheteria from '../services/bilheterias'



export default {

  data (){
  return{
    bilheterias: []
  }
},

  mounted(){
    Bilheteria.listar().then(resposta => {
      console.log(resposta.data)
      this.bilheterias = resposta.data
    })
  }
}
</script>

<style>

</style>
