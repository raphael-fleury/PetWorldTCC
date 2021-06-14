import { useState } from "react"
import Service from "services/ClienteService";
import Page from "types/Page"
import Cliente from "types/Cliente"
import EntityTable from   "components/tables/EntityTable"
import ConfirmDialog from "components/dialogs/ConfirmDialog"
import OkDialog from "components/dialogs/OkDialog";
import { Link } from "react-router-dom"

const ClientesTable = () => {
    
    const noDialog = <></>
    
    const [ dialog, setDialog ] = useState<JSX.Element>(noDialog);
    
    const deleteCliente = (cliente: Cliente) => {
        Service.delete(cliente.id)
            .then(() => setDialog(successDialog(cliente)))
            .catch(() => setDialog(errorDialog(cliente)))
    }

    const hideDialog = () => setDialog(noDialog);

    const removeDialog = (cliente: Cliente) => <ConfirmDialog
        title="Tem certeza?"
        desc={`Deseja mesmo remover ${cliente.nome}?`}
        confirmText="Sim"
        cancelText="Cancelar"
        onConfirm={() => deleteCliente(cliente)}
        onCancel={hideDialog}
    />

    const successDialog = (cliente: Cliente) => <OkDialog
        title="Removido com sucesso"
        desc={`${cliente.nome} foi removido.`}
        onClose={() => window.location.reload()}
    />

    const errorDialog = (cliente: Cliente) => <OkDialog
        title="Erro"
        desc={`Não foi possível remover ${cliente.nome}.`}
        onClose={hideDialog}
    />

    const showDialog = (cliente : Cliente) => {
        setDialog(removeDialog(cliente));
    }

    const headers = [ 'Nome', 'E-mail', 'Telefone', 'Endereço', 'Operações' ]

    const renderPage = (page : Page<Cliente>) => {
        if (!page.content)
            return []
        
        return page.content.map(cliente => (
            [
                <>{cliente.nome}</>,
                <>{cliente.email}</>,
                <>{cliente.telefone}</>,
                <>{cliente.endereco}</>,
                <>
                    <Link to={`clientes/detalhes/${cliente.id}`}>
                        <button className="btn btn-link p-1">Detalhes</button>
                    </Link>
                    <Link to={`clientes/editar/${cliente.id}`}>
                        <button className="btn btn-link p-1">Editar</button>
                    </Link>
                    <button className="btn btn-link p-1" onClick={() => showDialog(cliente)}>Remover</button>
                </>
            ]
        ))
    }

    const children = <Link to="/clientes/novo">
        <button className="btn btn-primary">Novo</button>
    </Link>

    const getPage = Service.getPage;
    const table = EntityTable<Cliente>({ headers, getPage, renderPage, children });

    return <> { dialog } { table } </>
}

export default ClientesTable;