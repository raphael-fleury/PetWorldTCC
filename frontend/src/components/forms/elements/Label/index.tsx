type Props = {
    htmlFor?: string,
    title?: string
}

const Label = ({ htmlFor, title }: Props) => {
    return (<label className="col-sm-2 col-form-label" htmlFor={htmlFor}>{title}</label>)
}

export default Label;