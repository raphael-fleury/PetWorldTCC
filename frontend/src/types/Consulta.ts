import Pet from "./Pet"
import Veterinario from "./Veterinario"

export type Consulta = {
    id: number
    atendimentoId?: number
    veterinario?: Veterinario
    pet?: Pet
    data: string
}

export type ConsultaInsert = {
    atendimentoId?: number
    sintomas: string
    prescricao: string
}

export default Consulta;