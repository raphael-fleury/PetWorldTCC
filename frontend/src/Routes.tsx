import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Pets from './pages/Pets';

const Routes = () => {
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact>
                    <Pets /> {/* temporary */}
                </Route>
                <Route path="/pets">
                    <Pets />
                </Route>
            </Switch>
        </BrowserRouter>
    )
}

export default Routes;