import moment, { Moment, weekdays } from "moment";
import { useState } from "react"
import './styles.css'

type Props = {
    date?: Date,
    onDateChange?: (moment: Moment) => void
}

const Calendar = ({ date, onDateChange }: Props) => {

    const today = moment();
    const initialDate = moment(date) ?? today;

    const monthsPt = ['Jan','Fev','Mar','Abr','Mai','Jun','Jul','Ago','Set','Out','Nov','Dez'];
    const weekDays = ['Dom','Seg','Ter','Qua','Qui','Sex','Sab'];

    const [activeDate, setDate] = useState(initialDate);
    const [month, setMonth] = useState(initialDate.month());
    const [year, setYear] = useState(initialDate.year());

    const changeDay = onDateChange ?? (() => {})

    const days = () => {
        let components = [];
        const date = moment(new Date(year, month, 1));
        
        for (let i = 0; i < date.weekday(); i++) {
            components.push(<td key={components.length} className="table-date nil" />)
        }

        for (let i = 1; i <= date.daysInMonth(); i++) {
            const aux = moment(new Date(year, month, i));
            const active = activeDate.isSame(aux, 'day');
            const className = "table-data " + (active ? "active-date" : "");
            const onClick = active ? () => {} :
            () => {
                setDate(aux);
                changeDay(aux);
            }

            const component = <td 
                key={components.length}
                className={className}
                onClick={onClick}
            >{i}</td>

            components.push(component);
        }

        return components
    }

    const rows = () => {
        const components = days()
        let rows = []

        for (let i = 0; i < 6; i++) {
            rows.push(<tr key={-i}>{ components.splice(0, 7) }</tr>);
        }

        return rows;
    }

    const months = monthsPt.map((m, index) => {
        const active = index === month;
        const className = "month " + (active ? "active-month" : "");
        const onClick = active ? () => {} : () => setMonth(index)
        return (
            <td
                className={className}
                key={index}
            >
                <a onClick={onClick}>{m}</a>
            </td>
        )
    })

    return (
        <div className="col-md-12">
            <div className="content w-100">
                <div className="calendar-container">
                    <div className="calendar">
                        <div className="year-header">
                            <span className="left-button fa fa-chevron-left" onClick={() => setYear(year - 1)}>&#9664;</span>
                            <span className="year" id="label">{ year }</span>
                            <span className="right-button fa fa-chevron-right" onClick={() => setYear(year + 1)}>&#9658;</span>
                        </div>
                        <table className="months-table w-100">
                            <tbody>
                                <tr className="months-row">{ months }</tr>
                            </tbody>
                        </table>
                        <table className="days-table w-100">
                            <thead><tr> {
                                weekDays.map((d, index) => (
                                    <td className="day" key={index}>{d}</td>
                                ))
                            } </tr></thead>
                            <tbody className="tbody">{ rows() }</tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Calendar;