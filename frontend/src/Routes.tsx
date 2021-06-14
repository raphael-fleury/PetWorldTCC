import { BrowserRouter, Route, Switch, Redirect } from 'react-router-dom';

import Home from './pages/Home';
import Login from './pages/Login';
import Registrar from './pages/Registrar';

import Pets from './pages/Pets/Menu';
import CadastrarPet from 'pages/Pets/Cadastrar';
import EditarPet from 'pages/Pets/Editar';
import DetalhesPet from 'pages/Pets/Detalhes';

import Clientes from 'pages/Clientes/Menu';
import CadastrarCliente from 'pages/Clientes/Cadastrar';
import EditarCliente from 'pages/Clientes/Editar';
import DetalhesCliente from 'pages/Clientes/Detalhes';

import UserService from 'services/UserService';

const Routes = () => {

    const guestRoutes = <>
        <Route path="/" exact>
            <Redirect to="/login" />
        </Route>

        <Route path="/login" exact>
            <Login />
        </Route>

        <Route path="/registrar" exact>
            <Registrar />
        </Route>

        <Route>
            <Redirect to="/login" />
        </Route>
    </>

    const petRoutes = <>
        <Route path="/pets" exact>
            <Pets />
        </Route>

        <Route path="/clientes/adicionar-pet/:id">
            <CadastrarPet />
        </Route>

        <Route path="/pets/editar/:id">
            <EditarPet />
        </Route>

        <Route path="/pets/detalhes/:id">
            <DetalhesPet />
        </Route>
    </>

    const clienteRoutes = <>
        <Route path="/clientes" exact>
            <Clientes />
        </Route>

        <Route path="/clientes/novo">
            <CadastrarCliente />
        </Route>

        <Route path="/clientes/editar/:id">
            <EditarCliente />
        </Route>

        <Route path="/clientes/detalhes/:id">
            <DetalhesCliente />
        </Route>
    </>

    const routes = <>
        <Route path="/" exact>
            <Home />
        </Route>

        { petRoutes }
        { clienteRoutes }

        <Route>
            <Redirect to="/" />
        </Route>
    </>

    return (
        <BrowserRouter>
            <Switch>
                { UserService.isLoggedIn() ? routes : guestRoutes }
            </Switch>
        </BrowserRouter>
    )
}

export default Routes;