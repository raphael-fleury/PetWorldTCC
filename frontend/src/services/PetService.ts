import { Pet, PetForm } from "types/Pet";
import Page from "types/Page";
import Client from "../services/Client";

const resource = "/pets";

export default {
    dummy: {
        id: 0, nome: '', especie: '', raca: '', sexo: '', castrado: false
    },

    async getPage(page?: number, size?: number) {
        return (await Client.get<Page<Pet>>(`${resource}?page=${page ?? 0}&size=${size ?? 10}`)).data
    },

    async getById(id: number) {
        return (await Client.get<Pet>(resource + "/" + id)).data
    },

    async post(pet: PetForm) {
        return (await Client.post<Pet>(resource, pet)).data
    },

    async put(id: number, pet: PetForm) {
        return (await Client.put<Pet>(resource + "/" + id, pet)).data
    },

    async delete(id: number) {
        return (await Client.delete<Pet>(resource + "/" + id)).data
    }
};