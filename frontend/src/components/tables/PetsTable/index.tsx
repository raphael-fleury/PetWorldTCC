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

    const headers = [ 'Nome', 'Espécie', 'Raça', 'Dono', 'Operações' ]

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
                    <Link to={`pets/detalhes/${pet.id}`}>
                        <button className="btn btn-link p-1">Detalhes</button>
                    </Link>
                    <Link to={`pets/editar/${pet.id}`}>
                        <button className="btn btn-link p-1">Editar</button>
                    </Link>
                    <button className="btn btn-link p-1" onClick={() => showDialog(pet)}>Remover</button>
                </>
            ]
        ))
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
        
    const getPage = Repository.getPage
    const table = EntityTable<Pet>({ headers, getPage , renderPage });

    return (
        <>
            { petToRemove.id !== 0 ? dialog() : <></> }      
            { table }
        </>
    )
}

export default PetsTable;