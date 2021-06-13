import './styles.css';

import OkDialog from 'components/dialogs/OkDialog';

import UserService from 'services/UserService';
import { useState } from 'react';
import { Link } from "react-router-dom"

const Registrar = () => {

    const [ nome, setNome ] = useState("");
    const [ email, setEmail ] = useState("");
    const [ senha, setSenha ] = useState("");
    const [ codigo, setCodigo ] = useState("");

    const submit = (event: any) => {
        event.preventDefault();
        UserService.register({ nome, email, senha })
            .then(code => setCodigo(code));
    }

    const dialog = <OkDialog
        title="Clínica criada com sucesso"
        desc={"Código: " + codigo}
        onClose={() => setCodigo("")}
    />

    return (
        <div className="registro">
            { codigo.length ? dialog : <></> }
            <div className="registro-container">
                <h2>Criar clínica</h2>
                <form className="registro-form mt-2" onSubmit={submit}>
                    <label className="row mb-2">Nome da clínica:
                        <input className="form-control" type="text" id="nome"
                            onChange={(event) => setNome(event.target.value)}
                            required autoFocus
                        />
                    </label>
                    <label className="row mb-2">E-mail:
                        <input className="form-control" type="email" id="email"
                            onChange={(event) => setEmail(event.target.value)}
                            required
                        />
                    </label>
                    <label className="row mb-2">Senha:
                        <input className="form-control" type="password" id="senha"
                            onChange={(event) => setSenha(event.target.value)}
                            required minLength={6} maxLength={24}
                        />
                    </label>

                    <button className="btn btn-registro mt-2" type="submit">Cadastrar</button>
                </form>
                <div className="pt-3 pb-3 link-login">
                    <Link to="/login">
                        <a href="#">Já estou cadastrado</a>
                    </Link>
                </div>
            </div>
        </div>
    )
}

export default Registrar;