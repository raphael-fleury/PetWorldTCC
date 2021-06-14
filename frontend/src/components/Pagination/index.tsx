import Page from "types/Page";

type Props = {
    page: Page<any>
    onPageChange: Function
    children?: JSX.Element
}

const Pagination = ({ page, onPageChange, children }: Props) => {
    return (
        <div className="row d-flex justify-content-center">
            <nav>
                <ul className="pagination">
                    { children }
                    { children ? <div className="mx-2" /> : <></> }
                    <li className={`page-item mr-0 ${page.first ? "disabled" : ""}`}>
                        <button className="page-link" onClick={() => onPageChange(page.number - 1)}>&#9664;</button>
                    </li>
                    <li className="page-item disabled">
                        <span className="page-link">{page.number + 1}</span>
                    </li>
                    <li className={`page-item ${page.last ? "disabled" : ""}`}>
                        <button className="page-link" onClick={() => onPageChange(page.number + 1)}>&#9658;</button>
                    </li>
                </ul>
            </nav>
        </div>
    )
}

export default Pagination;