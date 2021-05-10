import { useEffect, useState } from 'react';

type Row = {
    values: JSX.Element[]
}

type Props = {
    headers: string[]
    rows: Row[]
}

const DataTable = ({ headers, rows }: Props) => {

    const [activePage, setActivePage] = useState(0);

    return (
        <>
            <div className="table-responsive">
                <table className="table table-striped table-sm">
                    <thead>
                        <tr>
                            { headers.map((header, index) => (
                                <th key={index}>{header}</th>
                            ))
                            }
                        </tr>
                    </thead>
                    <tbody>
                        { rows.map((row, index) => (
                            <tr key={index}>
                                { row.values.map((value, index) => (
                                    <td key={index}>{value}</td>
                                ))
                                }
                            </tr>
                        ))
                        }
                    </tbody>
                </table>
            </div>
        </>
    );
}

export default DataTable;