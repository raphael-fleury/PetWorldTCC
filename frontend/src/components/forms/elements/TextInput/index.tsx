import Label from '../Label';

type Props = {
    id: string
    title: string
    placeholder?: string
    readonly?: boolean
    autofocus?: boolean
    size?: number
}

const TextInput = ({ id, title, placeholder, readonly, autofocus, size } : Props) => {

    if (!size || size < 0 || size > 5)
        size = 5

    return (
        <>
            <Label title={title}/>
            <div className={`col-sm-${size}`}>
                <input className="form-control"
                    type="text" id={id}
                    placeholder={placeholder}
                    autoFocus={autofocus} readOnly={readonly}
                />
            </div>
        </>
    )
}

export default TextInput;