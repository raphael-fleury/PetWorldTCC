import Pet from "./Pet"

type Cliente = {
    id: number
    nome: string
    email: string
    endereco: string
    telefone: string
    pets?: Pet[]
}

export default Cliente