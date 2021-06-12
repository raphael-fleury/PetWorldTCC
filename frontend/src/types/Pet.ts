import Cliente from './Cliente';
import Consulta from './Consulta'

export type Pet = {
    id: number
    nome: string
    especie: string
    raca: string
    castrado: boolean
    sexo: string
    dono?: Cliente
    consultas?: Consulta[]
}

export type PetForm = {
    nome: string
    especie: string
    raca: string
    castrado: boolean
    sexo: string
    donoId?: number
}

export default Pet