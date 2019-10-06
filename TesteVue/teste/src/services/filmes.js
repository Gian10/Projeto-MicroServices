import { http} from './config'

export default {

    listar:() => {
        return http.get('filmes')
    },
    salvar: (filmes) =>{
        return http.post('filmes/salvar', filmes)
    }
}