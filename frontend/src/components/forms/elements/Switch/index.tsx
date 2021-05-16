import Label from '../Label'
import './styles.css'

type Props = {
    id: string
    title: string
    checked?: boolean
}

const Switch = ({ id, title, checked }: Props) => {
    return (
        <>
            <Label title={title}/>
            <div className="btn-group btn-group-toggle col-sm-5">
                <label className="switch">
                    <input type="checkbox" />
                    <span className="slider round" />
                </label>   
            </div>           
        </>
    )
}

export default Switch;