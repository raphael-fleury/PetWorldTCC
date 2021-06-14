import SidebarManager from 'components/SidebarManager';
import Calendar from './Calendar';
import Dia from './Dia';
import { useState } from 'react';
import moment from 'moment';

const Home = () => {

    const [date, setDate] = useState(moment());

    return (
        <div className="container pt-3">
            <div className="row">
                <h1 className="text-primary py-3">Início</h1>
            </div>
            <div className="row">
                <div className="col">
                    <Calendar onDateChange={setDate}/>
                </div>
                <div className="col p-5">
                    <Dia date={date} />
                </div>
            </div>
        </div>
    )
}

export default Home;