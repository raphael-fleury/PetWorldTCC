import Pet from "./Pet"
import Veterinario from "./Veterinario"

export type Exame = {
    id: number
    atendimentoId?: number
    data: string
    nome: string
    descricao: string
    dataResultado: string
    veterinario?: Veterinario
    pet?: Pet
}

export type ExameInsert = {
    atendimentoId?: number
    nome: string
    descricao: string
    dataResultado: string
}

export default Exame;