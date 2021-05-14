import './styles.css'
import { useState } from 'react';
import Sidebar from '../Sidebar'

type Props = { actual : string }

const SidebarManager = ({actual} : Props) => {

    const [isSidebarHidden, setSidebarHidden] = useState(false);

    const show = () => setSidebarHidden(false);
    const hide = () => setSidebarHidden(true);

    return (
        <>
            <button id="open" className="btn btn-primary m-3" onClick={show}>&#9776;</button>
            <Sidebar actual={actual} hidden={isSidebarHidden} onClose={hide}/>
        </>
    )
}

export default SidebarManager;