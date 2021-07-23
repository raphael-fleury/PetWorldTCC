import VeterinarioForm from '../Form';
import VeterinarioService from 'services/VeterinarioService';
import { useState } from 'react';
import { VeterinarioInsert } from 'types/Veterinario';
import { Redirect } from 'react-router-dom';

const CadastrarVeterinario = () => {

    const [ created, setCreated ] = useState(0);

    function cadastrar(veterinario: VeterinarioInsert) {
        VeterinarioService.post(veterinario).then((res) => setCreated(res.id))
    }
    
    if (created) {
        return <Redirect to={`/veterinarios/detalhes/${created}`} />
    }

    return (
        <div className="container pt-3">
            <h1 className="text-primary py-3">Cadastrar Veterinário</h1>
            <VeterinarioForm onSubmit={cadastrar} />
        </div>
    )
}

export default CadastrarVeterinario;