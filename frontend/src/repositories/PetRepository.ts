import axios from "axios"
import Pet from "types/Pet";
import Page from "types/Page";
import { BACKEND_URL } from "utils/requests"

const BASE_URL = BACKEND_URL + "/pets";

export const getPage = (page?: number, size?: number) => {
    return axios.get<Page<Pet>>(`${BASE_URL}?page=${page ?? 0}&size=${size ?? 10}`)
}

export const getById = (id : number) => {
    return axios.get<Pet>(BASE_URL + "/" + id)
}

export const post = (pet : Pet) => {
    return axios.post<Pet>(BASE_URL, pet)
}

export const put = (id : number, pet : Pet) => {
    return axios.put<Pet>(BASE_URL + "/" + id, pet)
}

export const remove = (id : number) => {
    return axios.delete<Pet>(BASE_URL + "/" + id)
}