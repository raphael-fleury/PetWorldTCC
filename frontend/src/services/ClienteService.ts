import { Cliente, ClienteForm } from "types/Cliente";
import Page from "types/Page";
import Client from "../services/Client";

const resource = "/clientes";

export default {
    dummy: {
        id: 0, nome: '', email: '', endereco: '', telefone: ''
    },

    async getPage(page?: number, size?: number) {
        return (await Client.get<Page<Cliente>>(`${resource}?page=${page ?? 0}&size=${size ?? 10}`)).data
    },

    async getById(id: number) {
        return (await Client.get<Cliente>(resource + "/" + id)).data
    },

    async post(cliente: ClienteForm) {
        return (await Client.post<Cliente>(resource, cliente)).data
    },

    async put(id: number, cliente: ClienteForm) {
        return (await Client.put<Cliente>(resource + "/" + id, cliente)).data
    },

    async delete(id: number) {
        return (await Client.delete<Cliente>(resource + "/" + id)).data
    }
};