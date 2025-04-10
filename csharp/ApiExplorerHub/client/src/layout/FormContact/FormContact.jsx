import React, {useState} from "react";

const FormContact = (props) =>
{
    const [contactName, setContactName] = useState("");
    const [contactEmail, setContactEmail] = useState("");

    const submit = () => {
        const trimmedEmail = contactEmail.trim();
        const trimmedName = contactName.trim();
        if(trimmedEmail.length > 0 && trimmedName.length > 0)
        props.addContact(trimmedName, trimmedEmail);
        setContactName("");
        setContactEmail("");
    }

    return (
        <div>

            <div className="mb-3">
                <form>
                    <div className="mb-3">
                        <label className="form-label">Введите имя:</label>
                        <input 
                            className="form-control" 
                            type="text"
                            value={contactName}
                            onChange={(e) => { setContactName(e.target.value) }}
                        />
                    </div>

                    <div className="mb-3">
                        <label className="form-label">Введите e-mail:</label>
                        <textarea 
                            className="form-control"
                            value={contactEmail}
                            onChange={(e) => { setContactEmail(e.target.value) }}
                            rows={1}
                        >
                        </textarea>
                    </div>
                </form>

            </div>
            <div>       
                <button 
                    className="btn btn-primary"
                    onClick={() => {submit()}}
                >
                Добавить контакт
                </button>
            </div>
        </div>
    )
}

export default FormContact;