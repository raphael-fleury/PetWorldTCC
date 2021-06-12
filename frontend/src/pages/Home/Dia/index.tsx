import moment, { Moment } from "moment";
import { useEffect } from "react";
import { useState } from "react";
import { Link } from "react-router-dom";

import Service from "services/ConsultaService";
import Consulta from "types/Consulta";

type Props = { date: Moment }

const Dia = ({ date }: Props) => {

    const [ consultas, setConsultas ] = useState<Consulta[]>();
    const [ page, setPage ] = useState(0);
    
    useEffect(() => {
        Service.getByDate(date, page, 10).then(page => setConsultas(page.content))
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
                        consultas?.map(consulta => (
                            <tr>
                                <td>{moment(consulta.data).format("HH:mm")}</td>
                                <td>
                                    <Link to={`/veterinarios/${consulta.veterinario?.id}`}>
                                        {consulta.veterinario?.nome}
                                    </Link>
                                </td>
                                <td>
                                    <Link to={`/pets/${consulta.pet?.id}`}>
                                        {consulta.pet?.nome}
                                    </Link>
                                </td>
                                <td>
                                    <Link to={`/atendimentos/${consulta.id}`}>
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