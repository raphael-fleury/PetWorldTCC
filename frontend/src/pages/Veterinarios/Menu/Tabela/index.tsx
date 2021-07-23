import { useState } from "react"
import Service from "services/VeterinarioService";
import Page from "types/Page"
import Veterinario from "types/Veterinario"
import EntityTable from   "components/tables/EntityTable"
import ConfirmDialog from "components/dialogs/ConfirmDialog"
import OkDialog from "components/dialogs/OkDialog";
import { Link } from "react-router-dom"

const VeterinariosTable = () => {
    
    const noDialog = <></>
    
    const [ dialog, setDialog ] = useState<JSX.Element>(noDialog);
    
    const deleteVeterinario = (veterinario: Veterinario) => {
        Service.delete(veterinario.id)
            .then(() => setDialog(successDialog(veterinario)))
            .catch(() => setDialog(errorDialog(veterinario)))
    }

    const hideDialog = () => setDialog(noDialog);

    const removeDialog = (veterinario: Veterinario) => <ConfirmDialog
        title="Tem certeza?"
        desc={`Deseja mesmo remover ${veterinario.nome}?`}
        confirmText="Sim"
        cancelText="Cancelar"
        onConfirm={() => deleteVeterinario(veterinario)}
        onCancel={hideDialog}
    />

    const successDialog = (veterinario: Veterinario) => <OkDialog
        title="Removido com sucesso"
        desc={`${veterinario.nome} foi removido.`}
        onClose={() => window.location.reload()}
    />

    const errorDialog = (veterinario: Veterinario) => <OkDialog
        title="Erro"
        desc={`Não foi possível remover ${veterinario.nome}.`}
        onClose={hideDialog}
    />

    const showDialog = (veterinario : Veterinario) => {
        setDialog(removeDialog(veterinario));
    }

    const headers = [ 'Nome', 'E-mail', 'Telefone', 'Endereço', 'Operações' ]

    const renderPage = (page : Page<Veterinario>) => {
        if (!page.content)
            return []
        
        return page.content.map(veterinario => (
            [
                <>{veterinario.nome}</>,
                <>{veterinario.email}</>,
                <>{veterinario.telefone}</>,
                <>{veterinario.endereco}</>,
                <>
                    <Link to={`veterinarios/detalhes/${veterinario.id}`}>
                        <button className="btn btn-link p-1">Detalhes</button>
                    </Link>
                    <Link to={`veterinarios/editar/${veterinario.id}`}>
                        <button className="btn btn-link p-1">Editar</button>
                    </Link>
                    <button className="btn btn-link p-1" onClick={() => showDialog(veterinario)}>Remover</button>
                </>
            ]
        ))
    }

    const children = <Link to="/veterinarios/novo">
        <button className="btn btn-primary">Novo</button>
    </Link>

    const getPage = Service.getPage;
    const table = EntityTable<Veterinario>({ headers, getPage, renderPage, children });

    return <> { dialog } { table } </>
}

export default VeterinariosTable;