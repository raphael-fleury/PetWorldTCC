import Pet from "./Pet"

export type Cliente = {
    id: number
    nome: string
    email: string
    endereco: string
    telefone: string
    pets?: Pet[]
}

export type ClienteInsert = {
    nome: string
    email: string
    endereco: string
    telefone: string
}

export default Cliente;