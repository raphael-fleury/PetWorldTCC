import Pagination from '../../Pagination'
import DataTable from '../DataTable'
import Page from '../../../types/Page'
import { useState } from 'react'
import { useEffect } from 'react'

interface PageGetter<T> {
    (page: number, size: number) : Promise<Page<T>>
}

interface PageRenderer<T> {
    (page: Page<T>) : JSX.Element[][];
}

type Props<T> = {
    headers: string[],
    getPage: PageGetter<T>
    renderPage: PageRenderer<T>
    children?: JSX.Element
}

function EntityTable<T>({ headers, getPage, renderPage, children }: Props<T>) {
    
    const [data, setData] = useState<JSX.Element[][]>([[]]);

    const [page, setPage] = useState<Page<T>>({
        first: true,
        last: true,
        number: 0,
        totalElements: 0,
        totalPages: 0
    });
    
    const [activePage, setActivePage] = useState(0);
    
    useEffect(() => {
        getPage(activePage, 8)
            .then(page => {
                setPage(page)
                setData(renderPage(page))
            })
    }, [activePage]);

    return (
        <>
            <Pagination page={page} onPageChange={setActivePage}>{ children }</Pagination>
            <DataTable headers={headers} rows={data}/>
        </>
    )
}

export default EntityTable;