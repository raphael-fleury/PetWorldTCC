import './styles.css';

type Props = {
    title: string
    desc: string
    okText?: string
    onClose?: Function
    active?: boolean
}

const OkDialog = ({ title, desc, okText, onClose } : Props) => {

    const close = onClose ?? (() => {})

    return (
        <>
            <div className="modal" role="dialog">
                <div className="modal-dialog" role="document">
                    <div className="modal-content">
                        <div className="modal-header">
                            <h5 className="modal-title">{title}</h5>
                        </div>
                        <div className="modal-body">
                            <p>{desc}</p>
                        </div>
                        <div className="modal-footer">
                            <button type="button" onClick={() => close()} className="btn btn-primary" data-dismiss="modal">{okText ?? "OK"}</button>
                        </div>
                    </div>
                </div >
            </div >

            <div className="modal-backdrop fade show"></div>
        </>
    )
}

export default OkDialog;