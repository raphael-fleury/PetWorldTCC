import FormRow from 'components/forms/elements/FormRow';
import EntitySelect from 'components/forms/elements/EntitySelect';

import { AtendimentoInsert } from 'types/Atendimento';
import { useState, useEffect } from 'react';
import moment, { Moment } from 'moment';
import Pet from 'types/Pet';
import Veterinario from 'types/Veterinario';
import PetService from 'services/PetService';
import VeterinarioService from 'services/VeterinarioService';

type Props = {
    date?: Moment,
    onSubmit: (atendimento: AtendimentoInsert) => void
}

const AtendimentoInsertForm = ({ date, onSubmit }: Props) => {

    const now = moment();
    const [ data, setData] = useState(now.format("YYYY-MM-DD"));
    const [ horario, setHorario] = useState(now.format("HH:mm"));
    const [ vetId, setVetId] = useState(0);
    const [ petId, setPetId] = useState(0);

    const [ vetFilter, setVetFilter] = useState("");
    const [ petFilter, setPetFilter] = useState("");
    const [ pets, setPets ] = useState<Pet[]>([]);
    const [ vets, setVets ] = useState<Veterinario[]>([]);

    useEffect(() => {
        if (date) { setData(date.format("YYYY-MM-DD")); }
    }, [date])
    
    function filterVets(filter: string) {
        setVetFilter(filter)

        if (!filter.length) {
            setVets([])
            setVetId(0)
            return;
        }
        
        VeterinarioService.getByNameContains(filter)
            .then(res => {
                setVets(res)
                if (res.length) { setVetId(res[0].id) }
            })
    }

    function filterPets(filter: string) {
        setPetFilter(filter)

        if (!filter.length) {
            setPets([])
            setPetId(0)
            return;
        }

        PetService.getByNameContains(filter)
            .then(res => {
                setPets(res)
                if (res.length) { setPetId(res[0].id) }
            })
    }

    const canSubmit = (petId > 0) && (vetId > 0)

    function submit(event: any) {
        event?.preventDefault();

        const hr = Number.parseInt(horario.substr(0,2));
        const min = Number.parseInt(horario.substr(3,2));
        const datetime = moment(data).hour(hr).minutes(min);
        onSubmit({
            data: datetime.format("YYYY-MM-DDTHH:mm:ss.000Z"),
            petId, veterinarioId: vetId
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
            <FormRow title="Veterinário">
                <>
                <input type="text" className="form-control" placeholder="Filtrar por nome..."
                    value={vetFilter} onChange={(event) => filterVets(event.target.value)}
                />
                <EntitySelect entities={vets} onChange={setVetId} />
                </>
            </FormRow>
            <FormRow title="Pet">
                <>
                <input type="text" className="form-control" placeholder="Filtrar por nome..."
                    value={petFilter} onChange={(event) => filterPets(event.target.value)}
                />
                <EntitySelect entities={pets} onChange={setPetId} />
                </>
            </FormRow>
            <FormRow title="">
                <button disabled={!canSubmit} className="btn btn-primary" type="submit">Enviar</button>
            </FormRow>
        </form>
    )
}

export default AtendimentoInsertForm;