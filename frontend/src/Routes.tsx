import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Pets from './pages/Pets';

const Routes = () => {
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact>
                    <Pets />
                </Route>
                <Route path="/pets">
                    <Pets />
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