import moment, { Moment } from "moment";
import { Consulta, ConsultaForm } from "types/Consulta";
import Page from "types/Page";
import Client from "./Client";

const resource = "/consultas";

export default {
    dummy: {
        id: 0, data: '', sintomas: '', prescricao: ''
    },

    async getByDate(date: Moment, page?: number, size?: number) {
        let params = [
            "date=" + moment(date).format("YYYY-MM-DD"),
            "page=" + page ?? 0,
            "size=" + size ?? 10
        ].join("&")
        return (await Client.post<Page<Consulta>>(`${resource}/data?${params}`)).data
    },

    async getById(id: number) {
        return (await Client.get<Consulta>(resource + "/" + id)).data
    },

    async post(consulta: ConsultaForm) {
        return (await Client.post<Consulta>(resource, consulta)).data
    },

    async put(id: number, consulta: ConsultaForm) {
        return (await Client.put<Consulta>(resource + "/" + id, consulta)).data
    },

    async delete(id: number) {
        return (await Client.delete<Consulta>(resource + "/" + id)).data
    }
};