import Consulta from './Consulta'

export type Veterinario = {
    id: number
    nome: string
    email: string
    endereco: string
    telefone: string
    consultas?: Consulta[]
}

export type VeterinarioForm = {
    nome: string
    email: string
    endereco: string
    telefone: string
}

export default Veterinario