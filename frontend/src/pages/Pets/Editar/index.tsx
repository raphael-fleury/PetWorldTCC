import PetForm from '../Form';
import PetService from 'services/PetService';
import { Redirect, useParams } from 'react-router-dom';
import { useEffect } from 'react';
import { useState } from 'react';
import { PetInsert } from 'types/Pet';

const EditarPet = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);

    const [ pet, setPet ] = useState(PetService.dummy);
    const [ sucesso, setSucesso ] = useState(false);

    useEffect(() => {
        PetService.getById(id).then(res => setPet(res))
    }, [id])
    
    function editar(pet: PetInsert) {
        PetService.put(id, pet).then((res) => setSucesso(true))
    }
    
    if (sucesso) {
        return <Redirect to={`/pets/detalhes/${id}`} />
    }
    
    return (
        <div className="container pt-3">
            <h1 className="text-primary py-3">Editar Pet</h1>
            <PetForm pet={pet} onSubmit={editar}/>
        </div>
    )
}

export default EditarPet;