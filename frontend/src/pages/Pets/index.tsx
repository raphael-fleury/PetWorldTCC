import PetsTable from 'components/tables/PetsTable'
import SidebarManager from 'components/SidebarManager'

const Pets = () => {

    return (
        <>
            <SidebarManager actual="/pets" />
            <div className="container pt-3">
                <h1 className="text-primary py-3">Pets</h1>
                <PetsTable />
            </div>
        </>
    )
}

export default Pets;