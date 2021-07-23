type Entity = {
    id: number
    nome: string
}

type Props = {
    entities: Entity[]
    onChange?: (id: number) => void
}

function EntitySelect({ entities, onChange }: Props) {
    
    const changed = (event: any) => (onChange ?? (() => {}))(event.target.value);

    return <select onChange={changed} disabled={!entities.length} className="col-sm-1 form-select">
        { entities.map(e => <option key={e.id} value={e.id}>{e.nome}</option>) }
    </select>
}

export default EntitySelect;