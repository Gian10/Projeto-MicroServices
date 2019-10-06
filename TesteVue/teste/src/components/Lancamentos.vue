<template>
  <div id="app">

    <nav>
      <div class="nav-wrapper blue darken-1">
        <a href="#" class="brand-logo center"> CineMicroservice - Filmes em Laçamentos</a>
      </div>
    </nav>

    <div class="container">

      <!-- <form>

          <label>Nome</label>
          <input type="text" placeholder="Nome">
          <label>Valor</label>
          <input type="text" placeholder="Valor">

          <button class="waves-effect waves-light btn-small">Salvar<i class="material-icons left">save</i></button>

      </form> -->

      <table>

        <thead>

          <tr>
            <th>Nome</th>
            <th>Data</th>
            <th>Hora</th>
          </tr>

        </thead>

        <tbody>

          <tr v-for="movies of movies" :key="movies.id">
            <td>{{movies.Nome}} </td>
            <td>{{movies.Data}} </td>
            <td>{{movies.Hora}}</td>

          </tr>
          <br>
            <router-link to="/" class="waves-effect waves-light btn-small" tag="button">Voltar Para Filmes em Cartaz</router-link>

        </tbody>
      
      </table>

    </div>

  </div>
</template>


<script>
//import Filme from './services/filmes'
import Movies from '../services/movies'



export default {

  data (){
  return{
    movies: []
  }
},

  mounted(){
    Movies.listar().then(resposta => {
      console.log(resposta.data)
      this.movies = resposta.data
    })
  }
}
</script>

<style>

</style>
