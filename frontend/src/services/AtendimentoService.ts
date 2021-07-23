import moment, { Moment } from "moment";
import { Atendimento, AtendimentoInsert } from "types/Atendimento";
import Page from "types/Page";
import Client from "./Client";

const resource = "/atendimentos";

export default {
    dummy: {
        id: 0, data: ''
    },

    async getByDate(date: Moment, page?: number, size?: number) {
        let params = [
            "date=" + moment(date).format("YYYY-MM-DD"),
            "page=" + page ?? 0,
            "size=" + size ?? 10
        ].join("&")
        return (await Client.post<Page<Atendimento>>(`${resource}/data?${params}`)).data
    },

    async getById(id: number) {
        return (await Client.get<Atendimento>(resource + "/" + id)).data
    },

    async post(atendimento: AtendimentoInsert) {
        return (await Client.post<Atendimento>(resource, atendimento)).data
    },

    async put(id: number, atendimento: AtendimentoInsert) {
        return (await Client.put<Atendimento>(resource + "/" + id, atendimento)).data
    },

    async delete(id: number) {
        return (await Client.delete<Atendimento>(resource + "/" + id)).data
    }
};