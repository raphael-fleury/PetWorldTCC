import PetsTable from 'components/tables/PetsTable'

const Pets = () => {
    return (
        <>
            <div className="container">
                <h1 className="text-primary py-3">Pets</h1>
                <PetsTable />
            </div>
        </>
    );
}

export default Pets;