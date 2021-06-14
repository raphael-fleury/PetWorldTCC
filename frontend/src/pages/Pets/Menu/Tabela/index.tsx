import { useState } from "react"
import Service from "services/PetService";
import Page from "types/Page"
import Pet from "types/Pet"
import EntityTable from   "components/tables/EntityTable"
import ConfirmDialog from "components/dialogs/ConfirmDialog"
import OkDialog from "components/dialogs/OkDialog";
import { Link } from "react-router-dom"

const PetsTable = () => {
    
    const noDialog = <></>
    
    const [ dialog, setDialog ] = useState<JSX.Element>(noDialog);
    
    const deletePet = (pet: Pet) => {
        Service.delete(pet.id)
            .then(() => setDialog(successDialog(pet)))
            .catch(() => setDialog(errorDialog(pet)))
    }

    const hideDialog = () => setDialog(noDialog);

    const removeDialog = (pet: Pet) => <ConfirmDialog
        title="Tem certeza?"
        desc={`Deseja mesmo remover ${pet.nome}?`}
        confirmText="Sim"
        cancelText="Cancelar"
        onConfirm={() => deletePet(pet)}
        onCancel={hideDialog}
    />

    const successDialog = (pet: Pet) => <OkDialog
        title="Removido com sucesso"
        desc={`${pet.nome} foi removido.`}
        onClose={() => window.location.reload()}
    />

    const errorDialog = (pet: Pet) => <OkDialog
        title="Erro"
        desc={`Não foi possível remover ${pet.nome}.`}
        onClose={hideDialog}
    />

    const showDialog = (pet : Pet) => {
        setDialog(removeDialog(pet));
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

    const getPage = Service.getPage;
    const table = EntityTable<Pet>({ headers, getPage, renderPage });

    return <> { dialog } { table } </>
}

export default PetsTable;