import SidebarManager from 'components/SidebarManager';
import PetForm from 'components/forms/PetForm';
import PetService from 'services/PetService';
import { Redirect, useParams } from 'react-router-dom';
import { useState } from 'react';
import Pet, { PetInsert } from 'types/Pet';

const CadastrarPet = () => {

    const params = useParams<{ id: string }>();
    const donoId = Number.parseInt(params.id);

    const [ created, setCreated ] = useState(0);

    function cadastrar(pet: PetInsert) {
        PetService.post(pet).then((res) => setCreated(res.id))
    }
    
    if (created) {
        return <Redirect to={`/pets/detalhes/${created}`} />
    }
    
    return <>
        <SidebarManager actual="/pets" />
        <div className="container pt-3">
            <h1 className="text-primary py-3">Cadastrar Pet</h1>
            <PetForm donoId={donoId} onSubmit={cadastrar} />
        </div>
    </>
}

export default CadastrarPet;