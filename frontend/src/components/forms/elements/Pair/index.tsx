type Props = {
    title: string
    content: any
}

const Pair = ({ title, content }: Props) => {
    console.log(content);
    return (
        <div className="form-group row mb-3">
            <label className="col-sm-2 col-form-label" htmlFor={content.props.id}>{ title }</label>
            <div className="col-sm-5">{ content }</div>
        </div>
    )
}

export default Pair;