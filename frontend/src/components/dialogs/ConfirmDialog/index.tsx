import './styles.css';

type Props = {
    title: string
    desc: string
    cancelText?: string
    confirmText?: string
    onConfirm: Function
    onCancel: Function
    active?: boolean
}

const ConfirmDialog = ({ title, desc, cancelText, confirmText, onConfirm, onCancel } : Props) => {

    return (
        <>
            <div className="modal" tabIndex={-1} role="dialog">
                <div className="modal-dialog" role="document">
                    <div className="modal-content">
                        <div className="modal-header">
                            <h5 className="modal-title">{title}</h5>
                        </div>
                        <div className="modal-body">
                            <p>{desc}</p>
                        </div>
                        <div className="modal-footer">
                            <button type="button" onClick={() => onCancel()} className="btn btn-secondary" data-dismiss="modal">{cancelText ?? "Cancel"}</button>
                            <button type="button" onClick={() => onConfirm()} className="btn btn-danger">{confirmText  ?? "Confirm"}</button>
                        </div>
                    </div>
                </div >
            </div >

            <div className="modal-backdrop fade show"></div>
        </>
    )
}

export default ConfirmDialog;