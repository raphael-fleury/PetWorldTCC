import PetsTable from 'components/tables/PetsTable'
import Sidebar from 'components/Sidebar'

const Pets = () => {
    return (
        <div className="page">
            <Sidebar actual="/pets" />
            <div className="container px-3">
                <h1 className="text-primary py-3">Pets</h1>
                <PetsTable />
            </div>
        </div>
    )
}

export default Pets;