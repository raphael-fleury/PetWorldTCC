import './styles.css'
import { Link } from 'react-router-dom'
import logo from 'assets/img/logo.png'

type Props = {
    actual: string
}

const Sidebar = ({actual} : Props) => {

    function getLink(to : string, title : string) {
        return (
            <Link to={to}>
                <button className="sb-btn" disabled={to == actual}>{title}</button>
            </Link>
        )
    }

    return (
        <div id="sidebar">
            <img src={logo} alt="Home" width={110} className="m-5 mb-4" />
            <div id="links">
                { getLink("/", "Início") }
                { getLink("/pets", "Pets") }
                { getLink("/clientes", "Clientes") }
                { getLink("/veterinarios", "Veterinários") }
            </div>          
        </div>
    )
}

export default Sidebar