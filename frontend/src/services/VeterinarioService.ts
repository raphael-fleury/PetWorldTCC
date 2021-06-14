import { Veterinario, VeterinarioInsert } from "types/Veterinario";
import Page from "types/Page";
import Client from "./Client";

const resource = "/veterinarios";

export default {
    dummy: {
        id: 0, nome: '', email: '', endereco: '', telefone: ''
    },

    async getPage(page?: number, size?: number) {
        return (await Client.get<Page<Veterinario>>(`${resource}?page=${page ?? 0}&size=${size ?? 10}`)).data
    },

    async getById(id: number) {
        return (await Client.get<Veterinario>(resource + "/" + id)).data
    },

    async post(veterinario: VeterinarioInsert) {
        return (await Client.post<Veterinario>(resource, veterinario)).data
    },

    async put(id: number, veterinario: VeterinarioInsert) {
        return (await Client.put<Veterinario>(resource + "/" + id, veterinario)).data
    },

    async delete(id: number) {
        return (await Client.delete<Veterinario>(resource + "/" + id)).data
    }
};