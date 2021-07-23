type Props = {
    title: string
    children: JSX.Element
}

const FormRow = ({ title, children }: Props) => {

    return <div className="form-group row mb-3">
        <label className="col-sm-3 col-form-label" htmlFor={children.props.id}>{title}</label>
        <div className="col-sm-5">
            {children}
        </div>
    </div>
}

export default FormRow;