import Pet from "./Pet"
import Veterinario from "./Veterinario"

export type Atendimento = {
    id: number
    veterinario?: Veterinario
    pet?: Pet
    data: string
}

export type AtendimentoInsert = {
    veterinarioId?: number
    petId?: number
    data: string
}

export default Atendimento;