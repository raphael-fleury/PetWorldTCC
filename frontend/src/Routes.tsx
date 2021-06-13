import { BrowserRouter, Route, Switch, Redirect } from 'react-router-dom';
import Home from './pages/Home';
import Login from './pages/Login';
import Registrar from './pages/Registrar';
import Pets from './pages/crud/pets/Pets';

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

    const routes = <>
        <Route path="/" exact>
            <Home />
        </Route>

        <Route path="/pets" exact>
            <Pets />
        </Route>

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