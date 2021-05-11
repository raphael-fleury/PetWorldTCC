import { useState } from "react"
import Repository from "repositories/PetRepository";
import Page from "types/Page"
import Pet from "types/Pet"
import EntityTable from   "../EntityTable"
import ConfirmDialog from "../../dialogs/ConfirmDialog"
import { Router, Link } from "react-router-dom"

const PetsTable = () => {
    const dummyPet = {
        id: 0, nome: '', especie: '', raca: '', sexo: '', castrado: false
    }

    const [petToRemove, setPetToRemove] = useState<Pet>(dummyPet);

    const hideDialog = () => setPetToRemove(dummyPet);
    const showDialog = (pet : Pet) => setPetToRemove(pet);
    const deletePet = () => {
        Repository.delete(petToRemove.id);
        hideDialog();
    }

    const headers = [ 'Nome', 'Espécie', 'Raça', 'Dono', '' ]

    const renderPage = (page : Page<Pet>) => {
        if (!page.content)
            return []
        
        return page.content.map(pet => (
            [
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
        ))
    }

    async function getPage(page: number, size: number) : Promise<Page<Pet>> {
        return (await Repository.getPage(page, size)).data;
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

    const table = EntityTable<Pet>({ headers, getPage, renderPage });

    return (
        <>
            { petToRemove.id != 0 ? dialog() : <></> }      
            { table }
        </>
    )
}

export default PetsTable;