type Props = {
    children: JSX.Element
}

const Row = ({ children }: Props) => {
    return (
        <div className="form-group row mb-3">
            { children }
        </div>
    )
}

export default Row;