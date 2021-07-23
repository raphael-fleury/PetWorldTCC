import OnePerRow from 'components/forms/elements/OnePerRow';
import Service from 'services/AtendimentoService';
import { useEffect, useState } from 'react';
import Atendimento from 'types/Atendimento';
import { Link, useParams } from 'react-router-dom';
import moment from 'moment';
import OkDialog from 'components/dialogs/OkDialog';
import ConfirmDialog from 'components/dialogs/ConfirmDialog';

const DetalhesAtendimento = () => {

    const params = useParams<{ id: string }>();
    const id = Number.parseInt(params.id);

    const noDialog = <></>
    
    const [ dialog, setDialog ] = useState<JSX.Element>(noDialog);
    const [atendimento, setAtendimento] = useState<Atendimento>(Service.dummy);

    useEffect(() => {
        Service.getById(id).then(x => setAtendimento(x))
    }, [id]);

    const hideDialog = () => setDialog(noDialog);
    
    const removeDialog = <ConfirmDialog
        title="Tem certeza?"
        desc="Deseja mesmo remover este atendimento?"
        confirmText="Sim"
        cancelText="Cancelar"
        onConfirm={deleteAtendimento}
        onCancel={hideDialog}
    />

    const successDialog = <OkDialog
        title="Removido com sucesso"
        desc="O atendimento foi removido."
        onClose={() => window.location.reload()}
    />

    const errorDialog = <OkDialog
        title="Erro"
        desc={`Não foi possível remover o atendimento.`}
        onClose={hideDialog}
    />

    function deleteAtendimento() {
        Service.delete(id)
            .then(() => setDialog(successDialog))
            .catch(() => setDialog(errorDialog))
    }

    const getPair = (key: string, value: string) => {
        return <>
            <span className="col-sm-2 col-form-label">{key}</span>
            <span className="col-sm-2 col-form-label">{value}</span>
        </>
    }

    return (
        <div className="container pt-3">
            <h1 className="text-primary py-3">Atendimento</h1>
            { dialog }
            <OnePerRow>
                { getPair("Data/Horário", moment(atendimento.data).format("DD/MM/YYYY HH:mm")) }
                { getPair("Veterinário", atendimento.veterinario?.nome ?? "") }
                { getPair("Pet", atendimento.pet?.nome ?? "") }
            </OnePerRow>
            <Link to={`/atendimentos/editar/${id}`}>
                <button className="btn btn-link">Editar</button>
            </Link>
            <button onClick={() => setDialog(removeDialog)} className="btn btn-link">Excluir</button>
            <Link to="/">
                <button className="btn btn-link">Voltar ao início</button>
            </Link>
        </div>
    )
}

export default DetalhesAtendimento;