import FormRow from 'components/forms/elements/FormRow';

import { AtendimentoInsert } from 'types/Atendimento';
import { useState, useEffect } from 'react';
import moment, { Moment } from 'moment';

type Props = {
    date?: Moment,
    onSubmit: (atendimento: AtendimentoInsert) => void
}

const AtendimentoInsertForm = ({ date, onSubmit }: Props) => {

    const now = moment();
    const [ data, setData] = useState(now.format("YYYY-MM-DD"));
    const [ horario, setHorario] = useState(now.format("HH:mm"));
    const [ veterinario, setVeterinario] = useState("");
    const [ pet, setPet] = useState("");

    useEffect(() => {
        if (date) { setData(date.format("YYYY-MM-DD")); }
    }, [date])

    function submit(event: any) {
        event?.preventDefault();
        const hr = Number.parseInt(horario.substr(0,2));
        const min = Number.parseInt(horario.substr(3,2));
        const datetime = moment(data).hour(hr).minutes(min);
        onSubmit({
            data: datetime.format("YYYY-MM-DDTHH:mm:ss.000Z"),
            petId: Number.parseInt(pet),
            veterinarioId: Number.parseInt(veterinario)
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
            <FormRow title="Veterinário (código)">
            <input type="number" min={1} required className="form-control"
                value={veterinario} onChange={(event) => setVeterinario(event.target.value)}
            />
            </FormRow>
            <FormRow title="Pet (código)">
                <input type="number" min={1} required className="form-control"
                    value={pet} onChange={(event) => setPet(event.target.value)}
                />
            </FormRow>
            <FormRow title="">
                <button className="btn btn-primary" type="submit">Enviar</button>
            </FormRow>
        </form>
    )
}

export default AtendimentoInsertForm;