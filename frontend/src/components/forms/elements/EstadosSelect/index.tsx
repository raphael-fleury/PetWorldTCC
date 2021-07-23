type Props = {
    value?: string
    onChange?: any
}

const EstadosSelect = ({ value, onChange }: Props) => {
    
    const estados = ['AC','AL','AP','AM','BA','CE','DF','ES','GO','MA','MT','MS','MG','PA','PB','PR','PE','PI','RJ','RN','RS','RO','RR','SC','SP','SE','TO'];
    const changed = (event: any) => (onChange ?? (() => {}))(event.target.value);

    return <select id="estado" value={value ?? estados[0]} onChange={changed} className="col-sm-1 form-select">
        { estados.map(e => <option value={e}>{e}</option>) }
    </select>
}

export default EstadosSelect;