import AtendimentoUpdateForm from '../UpdateForm';
import AtendimentoService from 'services/AtendimentoService';
import { Redirect, useParams } from 'react-router-dom';
import { useEffect, useState } from 'react';
import { AtendimentoInsert } from 'types/Atendimento';

const EditarAtendimento = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);

    const [ atendimento, setAtendimento ] = useState(AtendimentoService.dummy);
    const [ sucesso, setSucesso ] = useState(false);

    useEffect(() => {
        AtendimentoService.getById(id).then(res => setAtendimento(res))
    }, [id])
    
    function editar(atendimento: AtendimentoInsert) {
        AtendimentoService.put(id, atendimento).then((res) => setSucesso(true))
    }
    
    if (sucesso) {
        return <Redirect to={`/atendimentos/detalhes/${id}`} />
    }

    return (
        <div className="container pt-3">
            <h1 className="text-primary py-3">Editar Atendimento</h1>
            <AtendimentoUpdateForm atendimento={atendimento} onSubmit={editar} />
        </div>
    )
}

export default EditarAtendimento;