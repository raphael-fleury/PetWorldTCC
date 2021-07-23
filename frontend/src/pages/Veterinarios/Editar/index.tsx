import VeterinarioForm from '../Form';
import VeterinarioService from 'services/VeterinarioService';
import { Redirect, useParams } from 'react-router-dom';
import { useEffect, useState } from 'react';
import { VeterinarioInsert } from 'types/Veterinario';

const EditarVeterinario = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);

    const [ veterinario, setVeterinario ] = useState(VeterinarioService.dummy);
    const [ sucesso, setSucesso ] = useState(false);

    useEffect(() => {
        VeterinarioService.getById(id).then(res => setVeterinario(res))
    }, [id])
    
    function editar(veterinario: VeterinarioInsert) {
        VeterinarioService.put(id, veterinario).then((res) => setSucesso(true))
    }
    
    if (sucesso) {
        return <Redirect to={`/veterinarios/detalhes/${id}`} />
    }

    return (
        <div className="container pt-3">
            <h1 className="text-primary py-3">Editar Veterinário</h1>
            <VeterinarioForm veterinario={veterinario} onSubmit={editar} />
        </div>
    )
}

export default EditarVeterinario;