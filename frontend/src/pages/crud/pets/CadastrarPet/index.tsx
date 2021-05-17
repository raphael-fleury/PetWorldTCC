import SidebarManager from '../../../../components/SidebarManager';
import PetForm from '../../../../components/forms/PetForm';

const CadastrarPet = () => {

    return (
        <>
            <SidebarManager actual="/pets" />
            <div className="container pt-3">
                <h1 className="text-primary py-3">Cadastrar Pet</h1>
                <PetForm />
            </div>
        </>
    )
}

export default CadastrarPet;