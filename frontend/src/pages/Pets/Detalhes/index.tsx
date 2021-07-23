import Service from 'services/PetService';
import PetCard from './Card';
import { useEffect, useState } from 'react';
import Pet from 'types/Pet';
import { useParams } from 'react-router-dom';

const DetalhesPet = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);
    
    const [pet, setPet] = useState<Pet>(Service.dummy);

    useEffect(() => {
        Service.getById(id).then(x => setPet(x))
    }, [id]);

    return <PetCard pet={pet} />
}

export default DetalhesPet;