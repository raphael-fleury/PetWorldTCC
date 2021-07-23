import './styles.css'

type Props = {
    id: string
    checked?: boolean
    onChange?: any
}

const Switch = ({ id, checked, onChange }: Props) => {

    const changed = (event: any) => (onChange ?? (() => {}))(event.target.value);

    return <div className="btn-group btn-group-toggle col-sm-5">
        <label className="switch">
            <input id={id} type="checkbox" checked={checked} onChange={changed} />
            <span className="slider round" />
        </label>   
    </div>    
}

export default Switch;