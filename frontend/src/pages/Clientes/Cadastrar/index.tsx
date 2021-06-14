import ClienteForm from '../Form';
import ClienteService from 'services/ClienteService';
import { useState } from 'react';
import { ClienteInsert } from 'types/Cliente';
import { Redirect } from 'react-router-dom';

const CadastrarCliente = () => {

    const [ created, setCreated ] = useState(0);

    function cadastrar(cliente: ClienteInsert) {
        ClienteService.post(cliente).then((res) => setCreated(res.id))
    }
    
    if (created) {
        return <Redirect to={`/clientes/detalhes/${created}`} />
    }

    return (
        <div className="container pt-3">
            <h1 className="text-primary py-3">Cadastrar Cliente</h1>
            <ClienteForm onSubmit={cadastrar} />
        </div>
    )
}

export default CadastrarCliente;