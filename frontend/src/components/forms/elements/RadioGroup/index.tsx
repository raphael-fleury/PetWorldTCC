import { useState } from "react"
import Label from '../Label'
import './styles.css'

type RadioInputProps = {
    title: string
    value: string
    checked?: boolean
}

type Props = {
    name: string
    title: string
    children: RadioInputProps[]
}

const RadioGroup = ({ name, title, children }: Props) => {

    const checked = children.filter(child => child.checked)[0]
    const [selected, setSelected] = useState(checked ? checked.value : children[0].value)

    const onValueChanged = (event : any) => {
        setSelected(event.target.value);
    }

    return (
        <>
            <Label title={title}/>
            <div 
                className="btn-group btn-group-toggle col-sm-5" 
                data-toggle="buttons"
                onChange={onValueChanged}
            >
            {
                children.map((child, index) => (
                    <RadioInput
                        key={index}
                        name={name}
                        title={child.title}
                        value={child.value}
                        checked={selected === child.value}
                    />
                ))
            }
            </div>       
        </>
    )
}

type FullRadioInputProps = {
    name: string
    title: string
    value: string
    checked?: boolean
}

const RadioInput = ({ name, title, value, checked }: FullRadioInputProps) => {
    return (
        <label className={`btn btn-secondary ${checked ? "active" : ""}`}>
            <input type="radio" autoComplete="off"
                name={name} value={value}
                checked={checked}
            /> {title}
        </label>
    )
}

export default RadioGroup;