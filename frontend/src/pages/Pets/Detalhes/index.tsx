import SidebarManager from 'components/SidebarManager';
import OnePerRow from 'components/forms/elements/OnePerRow';
import Label from 'components/forms/elements/Label';
import Service from 'services/PetService';
import { useEffect, useState } from 'react';
import Pet from 'types/Pet';
import { Link } from 'react-router-dom';

type Props = { id: number }

const DetalhesPet = ({ id }: Props) => {

    const [pet, setPet] = useState<Pet>(Service.dummy);

    useEffect(() => {
        Service.getById(id).then(x => setPet(x))
    });

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
            <SidebarManager actual="/pets" />
            <div className="container pt-3">
                <h1 className="text-primary py-3">{pet.nome}</h1>
                <OnePerRow>
                    <>
                        <span className="col-sm-2 col-form-label">Dono</span>
                        <Link to={`/clientes/${pet.dono?.id}`} className="col-sm-2 col-form-label">
                            {pet.dono?.nome}                     
                        </Link>
                    </>
                    { getPair("Espécie", pet.especie) }
                    { getPair("Raça", pet.raca ?? "?") }
                    { getPair("Castrado", pet.castrado ? "Sim" : "Não") }
                    { getPair("Sexo", pet.sexo) }                
                </OnePerRow>
                <div className="col-sm-4">
                        <button className="btn btn-link">Editar</button>
                        <button className="btn btn-link">Remover</button>
                </div>
            </div>
        </>    
    )
}

export default DetalhesPet;