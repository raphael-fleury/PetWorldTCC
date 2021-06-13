import Label from '../Label';

type Props = {
    id: string
    title: string
    placeholder?: string
    readonly?: boolean
    autofocus?: boolean
    size?: number
    min?: number
    max?: number
}

const NumberInput = ({ id, title, placeholder, readonly, autofocus, size, min, max } : Props) => {

    if (!size || size < 0 || size > 5)
        size = 5

    return (
        <>
            <Label title={title}/>
            <div className={`col-sm-${size}`}>
                <input className="form-control"
                    type="number" id={id} min={min} max={max}
                    placeholder={placeholder}
                    autoFocus={autofocus} readOnly={readonly}
                />
            </div>
        </>
    )
}

export default NumberInput;