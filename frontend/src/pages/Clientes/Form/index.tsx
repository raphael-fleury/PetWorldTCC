import EstadosSelect from 'components/forms/elements/EstadosSelect';
import FormRow from 'components/forms/elements/FormRow';

import { Cliente, ClienteInsert } from 'types/Cliente';
import { useState } from 'react';
import { useEffect } from 'react';

type Endereco = {
    logradouro: string
    numero: number
    complemento: string
    cidade: string
    estado: string
}

type Props = {
    cliente?: Cliente
    onSubmit: (cliente: ClienteInsert) => void
}

const ClienteForm = ({ cliente, onSubmit }: Props) => {

    const [ nome, setNome] = useState("");
    const [ email, setEmail] = useState("");
    const [ telefone, setTelefone] = useState("");
    const [ logradouro, setLogradouro] = useState("");
    const [ numero, setNumero] = useState(0);
    const [ complemento, setComplemento] = useState("");
    const [ cidade, setCidade] = useState("");
    const [ estado, setEstado] = useState("AC");

    const [ endereco, setEndereco] = useState("");
    
    useEffect(() => {
        if (!cliente) { return; }
        setNome(cliente.nome);
        setEmail(cliente.email);
        setTelefone(cliente.telefone);
        setEndereco(cliente.endereco);
    }, [cliente])

    function formatEndereco(endereco: Endereco) {
        const num = numero > 0 ? numero : "s/n";
        const comp = complemento ? `(${complemento}) ` : '';
        return `${logradouro}, ${num} ${comp}- ${cidade}/${estado}`
    }

    function submit(event: any) {
        event?.preventDefault();
        onSubmit({
            nome, email, telefone,
            endereco: endereco.length ? endereco :
                formatEndereco({ logradouro, numero, complemento, cidade, estado })
        })
    }

    const enderecoForm = (
        <fieldset>
            <legend>Endereço</legend>
            <FormRow title="Logradouro">
                <input type="text" id="logradouro" placeholder="Rua das Flores" className="form-control"
                    required value={logradouro} onChange={(event) => setLogradouro(event.target.value)}
                />
            </FormRow>
            <FormRow title="Número">
                <input type="number" id="numero" placeholder="123" min={0} className="form-control"
                    value={numero} onChange={(event) => setNumero(Number.parseInt(event.target.value))}
                />
            </FormRow>
            <FormRow title="Complemento">
                <input type="text" id="complemento" placeholder="Apartamento 50" className="form-control"
                    value={complemento} onChange={(event) => setComplemento(event.target.value)}
                />
            </FormRow>
            <FormRow title="Cidade">
                <input type="text" id="cidade" placeholder="Rio Branco" required className="form-control"
                    value={cidade} onChange={(event) => setCidade(event.target.value)}
                />
            </FormRow>
            <FormRow title="Estado">
                <EstadosSelect onChange={setEstado} />
            </FormRow>
        </fieldset>
    )

    return (
        <form onSubmit={submit}>
            <FormRow title="Nome">
                <input type="text" id="nome" placeholder="Carlos Andrade" className="form-control"
                    autoFocus required value={nome} onChange={(event) => setNome(event.target.value)}
                />
            </FormRow>
            <FormRow title="E-mail">
                <input type="email" id="email" placeholder="carlosandrade@exemplo.com" className="form-control"
                    required value={email} onChange={(event) => setEmail(event.target.value)}
                />
            </FormRow>
            <FormRow title="Telefone">
                <input type="text" id="telefone" placeholder="13988887777" className="form-control"
                    required value={telefone} onChange={(event) => setTelefone(event.target.value)}
                />
            </FormRow>
            { !endereco.length ? enderecoForm :
                <FormRow title="Endereço">
                    <input type="text" id="endereco" className="form-control"
                        required value={endereco} onChange={(event) => setEndereco(event.target.value)}
                    />
                </FormRow>
            }
            <FormRow title="">
                <button className="btn btn-primary" type="submit">Enviar</button>
            </FormRow>
        </form>
    )
}

export default ClienteForm;