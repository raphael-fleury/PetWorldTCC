import Label from '../Label';

type Props = {
    id: string
    title: string
    placeholder?: string
    readonly?: boolean
    autofocus?: boolean
}

const TextInput = ({ id, title, placeholder, readonly, autofocus } : Props) => {
    return (
        <>
            <Label title={title}/>
            <div className="col-sm-5">
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