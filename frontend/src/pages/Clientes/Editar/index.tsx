import SidebarManager from 'components/SidebarManager';
import ClienteForm from 'components/forms/ClienteForm';
import ClienteService from 'services/ClienteService';
import { Redirect, useParams } from 'react-router-dom';
import { useEffect, useState } from 'react';
import { ClienteInsert } from 'types/Cliente';

const EditarCliente = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);

    const [ cliente, setCliente ] = useState(ClienteService.dummy);
    const [ sucesso, setSucesso ] = useState(false);

    useEffect(() => {
        ClienteService.getById(id).then(res => setCliente(res))
    }, [id])
    
    function editar(cliente: ClienteInsert) {
        ClienteService.put(id, cliente).then((res) => setSucesso(true))
    }
    
    if (sucesso) {
        return <Redirect to={`/clientes/detalhes/${id}`} />
    }

    return <>
        <SidebarManager actual="/clientes" />
        <div className="container pt-3">
            <h1 className="text-primary py-3">Editar Cliente</h1>
            <ClienteForm cliente={cliente} onSubmit={editar} />
        </div>
    </>
}

export default EditarCliente;