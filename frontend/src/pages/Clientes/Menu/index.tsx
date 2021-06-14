import ClientesTable from 'components/tables/ClientesTable'
import SidebarManager from 'components/SidebarManager'

const Clientes = () => {

    return (
        <>
            <SidebarManager actual="/clientes" />
            <div className="container pt-3">
                <h1 className="text-primary py-3">Clientes</h1>
                <ClientesTable />
            </div>
        </>
    )
}

export default Clientes;