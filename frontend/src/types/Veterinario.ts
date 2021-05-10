import Consulta from './Consulta'

type Veterinario = {
    id: number
    nome: string
    email: string
    endereco: string
    telefone: string
    consultas?: Consulta[]
}

export default Veterinario