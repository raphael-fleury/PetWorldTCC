import Switch from '../elements/Switch';
import RadioGroup from '../elements/RadioGroup';
import FormRow from '../elements/FormRow';
import { useEffect, useState } from 'react';
import { Pet, PetInsert } from 'types/Pet';

type Props = {
    pet?: Pet
    onSubmit: (pet: PetInsert) => void
}

const PetForm = ({ pet, onSubmit }: Props) => {

    const [ nome, setNome] = useState("");
    const [ especie, setEspecie] = useState("");
    const [ raca, setRaca] = useState("");
    const [ castrado, setCastrado] = useState(false);
    const [ sexo, setSexo] = useState("MASCULINO");
    
    useEffect(() => {
        if (!pet) { return; }
        setNome(pet.nome)
        setEspecie(pet.especie)
        setRaca(pet.raca)
        setCastrado(pet.castrado)
        setSexo(pet.sexo)
    }, [pet])

    function submit(event: any) {
        event?.preventDefault();
        onSubmit({ nome, especie, raca, castrado, sexo })
    }

    return (
        <form onSubmit={submit}>
            <FormRow title="Nome">
                <input type="text" id="nome" placeholder="Rex" className="form-control"
                    autoFocus required value={nome} onChange={(event) => setNome(event.target.value)}
                />
            </FormRow>
            <FormRow title="Espécie">
                <input type="text" id="especie" placeholder="Cachorro" className="form-control"
                    required value={especie} onChange={(event) => setEspecie(event.target.value)}
                />
            </FormRow>
            <FormRow title="Raça">
                <input type="text" id="raca" placeholder="Poodle" className="form-control"
                    value={raca} onChange={(event) => setRaca(event.target.value)}
                />
            </FormRow>
            <FormRow title="Castrado">
                <Switch id="castrado" checked={castrado} onChange={() => setCastrado(!castrado)}/>
            </FormRow>
            <FormRow title="Sexo">
                <RadioGroup name="sexo" value={sexo} onChange={setSexo}>
                    {{ title: "Macho", value: "MASCULINO"}}
                    {{ title: "Fêmea", value: "FEMININO" }}
                </RadioGroup>
            </FormRow>
            <FormRow title="">
                <button className="btn btn-primary" type="submit">Enviar</button>
            </FormRow>
        </form>
    )
}

export default PetForm;