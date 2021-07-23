import FormRow from 'components/forms/elements/FormRow';

import { Atendimento, AtendimentoInsert } from 'types/Atendimento';
import { useState } from 'react';
import { useEffect } from 'react';
import moment from 'moment';

type Props = {
    atendimento: Atendimento
    onSubmit: (atendimento: AtendimentoInsert) => void
}

const AtendimentoUpdateForm = ({ atendimento, onSubmit }: Props) => {

    const [ data, setData] = useState("");
    const [ horario, setHorario] = useState("");

    useEffect(() => {
        const datetime = moment(atendimento.data);
        setData(datetime.format("YYYY-MM-DD"));
        setHorario(datetime.format("HH:mm"));
    }, [atendimento])

    function submit(event: any) {
        event?.preventDefault();
        const hr = Number.parseInt(horario.substr(0,2));
        const min = Number.parseInt(horario.substr(3,2));
        const datetime = moment(data).hour(hr).minutes(min);
        onSubmit({
            data: datetime.format("YYYY-MM-DDTHH:mm:ss.000Z")
        })
    }

    return (
        <form onSubmit={submit}>
            <FormRow title="Data">
                <input type="date" autoFocus required className="form-control"
                    value={data} onChange={(event) => setData(event.target.value)}
                />
            </FormRow>
            <FormRow title="Horário">
                <input type="time" required className="form-control"
                    value={horario} onChange={(event) => setHorario(event.target.value)}
                />
            </FormRow>
            <FormRow title="">
                <button className="btn btn-primary" type="submit">Enviar</button>
            </FormRow>
        </form>
    )
}

export default AtendimentoUpdateForm;