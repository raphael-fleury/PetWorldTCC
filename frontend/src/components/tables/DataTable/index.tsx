type Props = {
    headers: string[]
    rows: JSX.Element[][]
}

const DataTable = ({ headers, rows }: Props) => {

    return (
        <>
            <div className="table-responsive">
                <table className="table table-striped table-sm">
                    <thead>
                        <tr>
                            <th />
                            { headers.map((header, index) => (
                                <th key={index}>{header}</th>
                            ))}
                        </tr>
                    </thead>
                    <tbody>
                        { rows.map((row, index) => (
                            <tr key={index}>
                                <td />
                                { row.map((value, index) => (
                                    <td key={index} className="align-middle pl-5">{value}</td>
                                ))}
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