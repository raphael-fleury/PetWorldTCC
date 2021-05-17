import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Pets from './pages/crud/pets/Pets';
import CadastrarPet from './pages/crud/pets/CadastrarPet';

const Routes = () => {
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact>
                    <Pets />
                </Route>
                <Route path="/pets" exact>
                    <Pets />
                </Route>
                <Route path="/pets/cadastrar">
                    <CadastrarPet />
                </Route>
                <Route path="/clientes">
                    <Pets />
                </Route>
                <Route path="/veterinarios">
                    <Pets />
                </Route>
            </Switch>
        </BrowserRouter>
    )
}

export default Routes;