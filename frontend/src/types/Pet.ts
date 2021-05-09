import Cliente from './Cliente';

type Pet = {
    id: number
    nome: string
    especie: string
    raca: string
    castrado: boolean
    sexo: string
    dono: Cliente
}

export default Pet