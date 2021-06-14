import SidebarManager from 'components/SidebarManager';
import OnePerRow from 'components/forms/elements/OnePerRow';
import Service from 'services/ClienteService';
import { useEffect, useState } from 'react';
import Cliente from 'types/Cliente';
import { Link, useParams } from 'react-router-dom';

const DetalhesCliente = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);

    const [cliente, setCliente] = useState<Cliente>(Service.dummy);

    useEffect(() => {
        Service.getById(id).then(x => setCliente(x))
    }, [id]);

    const getPair = (key: string, value: string) => {
        return (
            <>
                <span className="col-sm-2 col-form-label">{key}</span>
                <span className="col-sm-2 col-form-label">{value}</span>
            </>
        )
    }

    return (
        <>
            <SidebarManager actual="/clientes" />
            <div className="container pt-3">
                <h1 className="text-primary py-3">{cliente.nome}</h1>
                <OnePerRow>
                    { getPair("E-mail", cliente.email) }
                    { getPair("Telefone", cliente.telefone) }
                    { getPair("Endereço", cliente.endereco) }
                    { getPair("Pets", "" + cliente.pets?.length) }                
                </OnePerRow>
                <Link to={`/clientes/adicionar-pet/${cliente.id}`}>
                    <button className="btn btn-link">Adicionar Pet</button>
                </Link>
                <Link to="/clientes">
                    <button className="btn btn-link">Ver todos os clientes</button>
                </Link>
            </div>
        </>    
    )
}

export default DetalhesCliente;