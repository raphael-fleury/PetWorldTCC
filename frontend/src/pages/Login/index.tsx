import logo from 'assets/img/logo.png';
import './styles.css';

import UserService from 'services/UserService';
import { useState } from 'react';
import { Link } from "react-router-dom"

const Login = () => {

    const [ codigo, setCodigo ] = useState("");
    const [ senha, setSenha ] = useState("");
    const [ notFound, setNotFound ] = useState(false);

    const submit = (event: any) => {
        event.preventDefault();
        UserService.login({ codigo, senha })
            .then(() => window.location.reload())
            .catch(err => setNotFound(true))
    }

    return (
        <div className="login">
            <div className="logo">
                <img src={logo} alt="Logo" />
            </div>
            <div className="login-container">
                <form className="login-form" onSubmit={submit}>
                    <label className="row mb-2">Código da clínica:
                        <input className="form-control" type="text" id="codigo"
                            onChange={(event) => setCodigo(event.target.value)}
                            required autoFocus minLength={6} maxLength={6}
                        />
                    </label>
                    <label className="row mb-2">Senha:
                        <input className="form-control" type="password" id="senha"
                            onChange={(event) => setSenha(event.target.value)}
                            required minLength={6} maxLength={24}
                        />
                    </label>

                    <button className="btn btn-login mt-2" type="submit">Login</button>
                </form>
                <div className="pt-3 pb-3 link-cadastro">
                    <Link to="/registrar">
                        <a href="#">Criar uma conta</a>
                    </Link>
                </div>
            </div>
            <div className="not-found mt-4">
                <span className="mt-2" hidden={!notFound}>Clínica não encontrada</span>
            </div>
        </div>
    )
}

export default Login;