import Filme from './components/Filmes.vue';
import Movie from './components/Lancamentos';
import Bilheteria from './components/Bilheterias';

const routes = [
    { path: '/', component: Filme },
    { path: '/movies', component: Movie },
    { path: '/bilheterias', component: Bilheteria },
];

export default routes;