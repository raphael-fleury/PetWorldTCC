import './styles.css'
import { useState } from 'react';
import Sidebar from './Sidebar'

const SidebarManager = () => {

    const [isSidebarHidden, setSidebarHidden] = useState(true);

    const show = () => setSidebarHidden(false);
    const hide = () => setSidebarHidden(true);

    return <>
        <button id="open" className="btn btn-primary m-3" onClick={show}>&#9776;</button>
        <Sidebar hidden={isSidebarHidden} onClose={hide}/>
    </>
}

export default SidebarManager;