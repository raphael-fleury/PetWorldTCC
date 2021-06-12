import Pet from "./Pet"
import Veterinario from "./Veterinario"

export type Consulta = {
    id: number
    veterinario?: Veterinario
    pet?: Pet
    data: string
    sintomas: string
    prescricao: string
}

export type ConsultaForm = {
    veterinarioId?: number
    petId?: number
    data: string
    sintomas: string
    prescricao: string
}

export default Consulta;