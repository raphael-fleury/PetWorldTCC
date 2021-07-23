import './styles.css'
import Pet from '../../../../types/Pet';
import { Link } from 'react-router-dom';
import OnePerRow from 'components/forms/elements/OnePerRow';
import { useState } from 'react';
import { useEffect } from 'react';
import PetService from 'services/PetService';
import Atendimento from 'types/Atendimento';
import Exame from 'types/Exame';
import moment from 'moment';
import AtendimentoService from 'services/AtendimentoService';

type Props = { pet: Pet }

const PetCard = ({ pet }: Props) => {

    const [ atendimentos, setAtendimentos ] = useState<Atendimento[]>([]);
    const [ exames, setExames ] = useState<Exame[]>([]);

    useEffect(() => {
        PetService.getAtendimentos(pet.id)
            .then(res => setAtendimentos(res.content ?? []))

        PetService.getExames(pet.id)
            .then(res => setExames(res.content ?? []))
    }, [pet])

    function getAtendimentos(): Atendimento[] {
        for (let i = 0; i < atendimentos.length; i++) {
            console.log(atendimentos[i].id);
        }
        return atendimentos;
    }

    function getRow(title: string, children: JSX.Element) {
        return (
            <div className="props-row mb-2">
                <span className="prop-key">{title}</span>
                <div className="prop-value">
                    {children}
                </div>
            </div>
        )
    }


    return (
        <div className="pet-card">
            <h2>{pet.nome}</h2>
            <div className="card-content">
                <div className="props">
                    { getRow('Dono', 
                        <Link to={`/clientes/detalhes/${pet.dono?.id}`} className="col-sm-2 col-form-label">
                            {pet.dono?.nome}                     
                        </Link>
                    )}
                    { getRow('Espécie', <span>{ pet.especie }</span>) }
                    { pet.raca ? getRow('Raça', <span>{ pet.raca }</span>) : <></> }
                    { getRow('Castrado', <span>{ pet.castrado ? "Sim" : "Não" }</span>) }
                    { getRow('Sexo', <span>{ pet.sexo }</span>) }
                </div>
                <div className="prontuario col">
                    <h5>Atendimentos</h5>
                    <table>
                        <thead>
                            <td>Data</td>
                            <td>Horário</td>
                            <td>Veterinário</td>
                            <td>...</td>
                        </thead>
                        <tbody>
                        {
                            atendimentos?.map(atendimento => (
                                <tr>
                                    <td>{moment(atendimento.data).format("DD/MM/YYYY")}</td>
                                    <td>{moment(atendimento.data).format("HH:mm")}</td>
                                    <td>
                                        <Link to={`/veterinarios/detalhes/${atendimento.veterinario?.id}`}>
                                            {atendimento.veterinario?.nome}
                                        </Link>
                                    </td>
                                    <td>
                                        <Link to={`/atendimentos/detalhes/${atendimento.id}`}>
                                            Detalhes
                                        </Link>
                                    </td>
                                </tr>
                            ))
                        }
                        </tbody>
                    </table>
                    <h5 className="mt-2">Exames</h5>
                    { exames.map(exame => (
                        getRow(moment(exame.data).format("DD/MM/YYYY"), <span>{ exame.nome }</span>)
                    ))
                    }
                </div>
            </div>  
            <div className="controles">
                <Link to={`/pets/editar/${pet.id}`}>
                    <button className="btn btn-link">Editar</button>
                </Link>
                <Link to="/pets">
                    <button className="btn btn-link">Ver todos os pets</button>
                </Link>
            </div>
        </div>
    )
}

export default PetCard;