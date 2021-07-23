import OnePerRow from 'components/forms/elements/OnePerRow';
import Service from 'services/VeterinarioService';
import { useEffect, useState } from 'react';
import Veterinario from 'types/Veterinario';
import { Link, useParams } from 'react-router-dom';

const DetalhesVeterinario = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);

    const [veterinario, setVeterinario] = useState<Veterinario>(Service.dummy);

    useEffect(() => {
        Service.getById(id).then(x => setVeterinario(x))
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
        <div className="container pt-3">
            <h1 className="text-primary py-3">{veterinario.nome}</h1>
            <OnePerRow>
                { getPair("E-mail", veterinario.email) }
                { getPair("Telefone", veterinario.telefone) }
                { getPair("Endereço", veterinario.endereco) }
            </OnePerRow>
            <Link to="/veterinarios">
                <button className="btn btn-link">Ver todos os veterinários</button>
            </Link>
        </div>
    )
}

export default DetalhesVeterinario;