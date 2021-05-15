import Label from '../Label'

type Props = {
    onReset?: Function
    onSubmit?: Function
}

const ResetAndSubmit = ({ onReset, onSubmit } : Props) => {
    
    const reset = onReset ?? (() => {})
    const submit = onSubmit ?? (() => {})
    
    return (
        <>
            <Label/>
            <div className="col-sm-6">
                <button className="btn btn-link" type="reset" onClick={() => reset()}>Limpar</button>
                <button className="btn btn-primary mx-2" type="submit" onClick={() => submit()}>Enviar</button>
            </div>
        </>
    )
}

export default ResetAndSubmit;