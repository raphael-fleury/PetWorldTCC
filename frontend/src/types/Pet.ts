import Cliente from './Cliente';

export type Pet = {
    id: number
    nome: string
    especie: string
    raca: string
    castrado: boolean
    sexo: string
    dono?: Cliente
}

export type PetInsert = {
    nome: string
    especie: string
    raca: string
    castrado: boolean
    sexo: string
    donoId?: number
}

export default Pet