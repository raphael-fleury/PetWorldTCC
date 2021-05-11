import Pet from "types/Pet";
import Page from "types/Page";
import Client from "../repositories/Client";

const resource = "/pets";

export default {
    getPage(page?: number, size?: number) {
        return Client.get<Page<Pet>>(`${resource}?page=${page ?? 0}&size=${size ?? 10}`)
    },

    getById(id: number) {
        return Client.get<Pet>(resource + "/" + id)
    },

    post(pet: Pet) {
        return Client.post<Pet>(resource, pet)
    },

    put(id: number, pet: Pet) {
        return Client.put<Pet>(resource + "/" + id, pet)
    },

    delete(id: number) {
        return Client.delete<Pet>(resource + "/" + id)
    }
};