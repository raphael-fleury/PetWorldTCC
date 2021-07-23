import './styles.css'

type RadioInputProps = {
    title: string
    value: string
    checked?: boolean
}

type Props = {
    name: string
    value: string
    children: RadioInputProps[]
    onChange?: any
}

const RadioGroup = ({ name, value, children, onChange }: Props) => {

    const onValueChanged = (event : any) => {
        (onChange ?? (() => {}))(event.target.value);
    }

    return (
        <div
            className="btn-group btn-group-toggle col-sm-5" 
            data-toggle="buttons"
            onChange={onValueChanged}
        >
        {
            children.map((child, index) => (
                <RadioInput
                    key={index}
                    title={child.title}
                    value={child.value}
                    checked={value === child.value}
                />
            ))
        }
        </div>       
    )
}

type FullRadioInputProps = {
    title: string
    value: string
    checked?: boolean
}

const RadioInput = ({ title, value, checked }: FullRadioInputProps) => {
    return (
        <label className={`btn btn-secondary ${checked ? "active" : ""}`}>
            <input type="radio" autoComplete="off"
                value={value} checked={checked}
            /> {title}
        </label>
    )
}

export default RadioGroup;