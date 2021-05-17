import Switch from 'components/forms/elements/Switch';
import OnePerRow from 'components/forms/elements/OnePerRow';
import TextInput from 'components/forms/elements/TextInput';
import RadioGroup from 'components/forms/elements/RadioGroup';
import ResetAndSubmit from 'components/forms/elements/ResetAndSubmit';

const PetForm = () => {
    return (
        <form>
            <OnePerRow>
                <TextInput id="nome" title="Nome" placeholder="Rex" autofocus/>
                <TextInput id="especie" title="Espécie" placeholder="Cachorro"/>
                <TextInput id="raca" title="Raça" placeholder="Poodle"/>
                <Switch id="castrado" title="Castrado"/>
                <RadioGroup name="sexo" title="Sexo">
                    {{ title: "Macho", value: "MASCULINO" }}
                    {{ title: "Fêmea", value: "FEMININO" }}
                </RadioGroup>
                <ResetAndSubmit/>
            </OnePerRow>
        </form>
    )
}

export default PetForm;