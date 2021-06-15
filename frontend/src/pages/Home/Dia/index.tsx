import moment, { Moment } from "moment";
import { useEffect } from "react";
import { useState } from "react";
import { Link } from "react-router-dom";

import Service from "services/AtendimentoService";
import Atendimento from "types/Atendimento";

type Props = { date: Moment }

const Dia = ({ date }: Props) => {

    const [ atendimentos, setAtendimentos ] = useState<Atendimento[]>();
    const [ page, setPage ] = useState(0);
    
    useEffect(() => {
        Service.getByDate(date, page, 10).then(page => setAtendimentos(page.content))
    }, [date, page]);

    return (
        <>
            <h2 className="mb-3">{ date.format("DD/MM/YYYY") }</h2>
            <h4>Atendimentos:</h4>
            <div className="table-responsive">
                <table className="table table-sm">
                    <thead>
                        <td>Horário</td>
                        <td>Veterinário</td>
                        <td>Pet</td>
                        <td>...</td>
                    </thead>
                    <tbody>
                    {
                        atendimentos?.map(atendimento => (
                            <tr>
                                <td>{moment(atendimento.data).format("HH:mm")}</td>
                                <td>
                                    <Link to={`/veterinarios/detalhes/${atendimento.veterinario?.id}`}>
                                        {atendimento.veterinario?.nome}
                                    </Link>
                                </td>
                                <td>
                                    <Link to={`/pets/detalhes/${atendimento.pet?.id}`}>
                                        {atendimento.pet?.nome}
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
                <Link to="/atendimentos/novo">
                    <button className="btn btn-primary">Novo atendimento</button>
                </Link>
            </div>
        </>
    )
}

export default Dia;