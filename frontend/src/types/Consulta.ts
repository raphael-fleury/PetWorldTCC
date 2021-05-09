import Pet from "./Pet"
import Veterinario from "./Veterinario"

type Consulta = {
    id: number
    veterinario: Veterinario
    pet: Pet
    data: string
    sintomas: string
    prescricao: string
}

export default Consulta