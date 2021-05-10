type Page<T> = {
    content?: T[]
    totalElements: number
    totalPages: number
    first: boolean
    last: boolean
    size?: number
    number: number
    numberOfElements?: number
    empty?: boolean
}

export default Page;