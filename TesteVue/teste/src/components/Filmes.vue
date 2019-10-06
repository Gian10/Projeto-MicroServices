<template>
  <div id="app">

    <nav>
      <div class="nav-wrapper blue darken-1">
        <a href="#" class="brand-logo center"> CineMicroservice - Filmes em Cartaz</a>
      </div>
    </nav>

    

    <div class="container">


      <table>

        <thead>

          <tr>
            <th>Filme</th>
            <th>Preço Estudante R$</th>
            <th>Preço Inteira R$</th>
            <th>Data</th>
          </tr>      

        </thead>
        

        <tbody>
          

          <tr v-for="filmes of filmes" :key="filmes.id">

            <td>{{filmes.Nome}}</td>
            <td>{{filmes.PrecoMeia}} </td>
            <td>{{filmes.PrecoInteira}} </td>
            <td>{{filmes.Data}}</td>

          </tr>
          <br>
        <!-- <button class="waves-effect waves-light btn-small">Filmes em Lançamento</button> -->
        <router-link to="/movies" class="waves-effect waves-light btn-small" tag="button">Lançamento de Filmes</router-link>
       
        <br>
        <br>
        <br>
  
         <dv id="a">
        <router-link to="/bilheterias"  class="waves-effect waves-light btn-small" tag="button">Record de Bilheteria</router-link>
        </dv>

        
        </tbody>
      </table>

    </div>
    
  </div>
</template>


<script>
//import Filme from './services/filmes'
import Filme from '../services/filmes'



export default {

  data (){
  return{
    filmes: []
  }
},

  mounted(){
    Filme.listar().then(resposta => {
      console.log(resposta.data)
      this.filmes = resposta.data
    })
  }
}
</script>

<style>
.button {
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  cursor: pointer;
}

</style>
