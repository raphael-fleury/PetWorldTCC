import './styles.css'
import { Link } from 'react-router-dom'
import logo from 'assets/img/logo.png'

import UserService from 'services/UserService';

type Props = {
    hidden: boolean
    onClose: Function
}

const Sidebar = ({ hidden, onClose } : Props) => {

    function getLink(to : string, title : string) {
        return (
            <Link to={to}>
                <button className="sb-btn">{title}</button>
            </Link>
        )
    }

    function logout() {
        UserService.logout();
        window.location.reload();
    }

    return (
        <>
            <div className={hidden ? "" : "modal"} role="dialog">
                <div id="sidebar" className={hidden ? "hidden" : ""}>
                    <button id="close" className="btn" onClick={() => onClose()}>X</button>
                    <div id="elements">
                        <img src={logo} alt="Home" width={110} className="m-5 mb-4" />
                        <div id="links">
                            { getLink("/", "Início") }
                            { getLink("/pets", "Pets") }
                            { getLink("/clientes", "Clientes") }
                            { getLink("/veterinarios", "Veterinários") }
                            <button className="sb-btn" onClick={logout}>Sair</button>
                        </div>
                    </div>
                </div>
            </div>
            
            { hidden ? <></> : <div className="modal-backdrop fade show"></div> }
        </>
    )
}

export default Sidebar