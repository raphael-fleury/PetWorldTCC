import Cliente from './Cliente';
import Consulta from './Consulta'

type Pet = {
    id: number
    nome: string
    especie: string
    raca: string
    castrado: boolean
    sexo: string
    dono?: Cliente
    consultas?: Consulta[]
}

export default Pet