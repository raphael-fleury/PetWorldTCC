import SidebarManager from 'components/SidebarManager';
import OnePerRow from 'components/forms/elements/OnePerRow';
import Service from 'services/PetService';
import { useEffect, useState } from 'react';
import Pet from 'types/Pet';
import { Link, useParams } from 'react-router-dom';

const DetalhesPet = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);
    
    const [pet, setPet] = useState<Pet>(Service.dummy);

    useEffect(() => {
        Service.getById(id).then(x => setPet(x))
    }, [id]);

    const getPair = (key: string, value: string) => {
        return <>
            <span className="col-sm-2 col-form-label">{key}</span>
            <span className="col-sm-2 col-form-label">{value}</span>
        </>
    }

    return (
        <>
            <SidebarManager actual="/pets" />
            <div className="container pt-3">
                <h1 className="text-primary py-3">{pet.nome}</h1>
                <OnePerRow>
                    <>
                        <span className="col-sm-2 col-form-label">Dono</span>
                        <Link to={`/clientes/detalhes/${pet.dono?.id}`} className="col-sm-2 col-form-label">
                            {pet.dono?.nome}                     
                        </Link>
                    </>
                    { getPair("Espécie", pet.especie) }
                    { getPair("Raça", pet.raca ?? "?") }
                    { getPair("Castrado", pet.castrado ? "Sim" : "Não") }
                    { getPair("Sexo", pet.sexo) }                
                </OnePerRow>
                <Link to="/pets">
                    <button className="btn btn-link">Ver todos os pets</button>
                </Link>
            </div>
        </>    
    )
}

export default DetalhesPet;