import axios from "axios"
import { useEffect, useState } from "react"
import Page from "../../types/Page"
import Pet from "../../types/Pet"
import DataTable from "../DataTable"
import Pagination from "../Pagination"
import ConfirmDialog from "../dialogs/ConfirmDialog"
import { BACKEND_URL } from "../../utils/requests"
import { Link } from "react-router-dom"

const PetsTable = () => {
    
    const dummyPet = {
        id: 0, nome: '', especie: '', raca: '', sexo: '', castrado: false
    }

    const [page, setPage] = useState<Page<Pet>>({
        first: true,
        last: true,
        number: 0,
        totalElements: 0,
        totalPages: 0
    });
    
    const [activePage, setActivePage] = useState(0);
    const [petToRemove, setPetToRemove] = useState<Pet>(dummyPet);

    useEffect(() => {
        axios.get(`${BACKEND_URL}/pets?page=${activePage}&size=10`)
            .then(response => {
                const data = response.data as Page<Pet>;
                setPage(data);
            })
    }, [activePage]);

    const deletePet = () => { hideDialog() }
    const hideDialog = () => setPetToRemove(dummyPet);
    const showDialog = (pet : Pet) => setPetToRemove(pet);

    const headers = [ 'Nome', 'Espécie', 'Raça', 'Dono', '' ]

    const getRows = () => {
        if (!page.content)
            return [ { values: [] } ]
        
        return page.content.map(pet => ({
            values : [
                <>{pet.nome}</>,
                <>{pet.especie}</>,
                <>{pet.raca}</>,
                <>{pet.dono?.nome}</>,
                <>
                    {/* <span></span>
                    <a href={`pets/${pet.id}`}>Detalhes</a>
                    <a href={`pets/editar/${pet.id}`}>Editar</a>
                    <a href={`pets/remover/${pet.id}`}>Remover</a>
                    <Link to={`pets/editar/${pet.id}`}>
                        <a>Editar</a>
                    </Link>
                    <button >Remover</button>
                    <button className="page-link">Remover</button> */}
                    <button className="btn btn-link" onClick={() => showDialog(pet)}>Remover</button>
                </>
            ]
        }))
    }

    const dialog = () => {
        return (
            <ConfirmDialog
                title="Tem certeza?"
                desc={`Deseja mesmo remover ${petToRemove.nome}?`}
                onConfirm={deletePet}
                onCancel={hideDialog}
            />
        )
    }

    return (
        <>
            { petToRemove.id != 0 ? dialog() : <></> }      
            <Pagination page={page} onPageChange={setActivePage}/>
            <DataTable headers={headers} rows={getRows()}/>
        </>
    )
}

export default PetsTable;