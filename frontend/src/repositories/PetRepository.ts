import Pet from "types/Pet";
import Page from "types/Page";
import Client from "../repositories/Client";

const resource = "/pets";

export default {
    async getPage(page?: number, size?: number) {
        return (await Client.get<Page<Pet>>(`${resource}?page=${page ?? 0}&size=${size ?? 10}`)).data
    },

    async getById(id: number) {
        return (await Client.get<Pet>(resource + "/" + id)).data
    },

    async post(pet: Pet) {
        return (await Client.post<Pet>(resource, pet)).data
    },

    async put(id: number, pet: Pet) {
        return (await Client.put<Pet>(resource + "/" + id, pet)).data
    },

    async delete(id: number) {
        return (await Client.delete<Pet>(resource + "/" + id)).data
    }
};