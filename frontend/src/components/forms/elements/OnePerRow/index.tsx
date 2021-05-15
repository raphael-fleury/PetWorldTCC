import Row from "../Row"

type Props = {
    children: JSX.Element[]
}

const OnePerRow = ({ children }: Props) => {
    return (
        <> {
            children.map((child, index) => (
                <Row>{child}</Row>
            ))
        } </>
    )
}

export default OnePerRow;