import AtendimentoInsertForm from '../InsertForm';
import AtendimentoService from 'services/AtendimentoService';
import { useState } from 'react';
import { AtendimentoInsert } from 'types/Atendimento';
import { Redirect } from 'react-router-dom';

const CadastrarAtendimento = () => {

    const [ created, setCreated ] = useState(0);

    function cadastrar(atendimento: AtendimentoInsert) {
        AtendimentoService.post(atendimento).then((res) => setCreated(res.id))
    }
    
    if (created) {
        return <Redirect to={`/atendimentos/detalhes/${created}`} />
    }

    return (
        <div className="container pt-3">
            <h1 className="text-primary py-3">Novo Atendimento</h1>
            <AtendimentoInsertForm onSubmit={cadastrar} />
        </div>
    )
}

export default CadastrarAtendimento;