import React, { useState, useEffect} from "react";
import { useParams, useNavigate } from "react-router-dom";
import axios from "axios";

const baseApiUrl = process.env.REACT_APP_API_URL;


const ContactDetails = () => {
    const [contact, setContact] = useState({name:"", email:""});
    const {id} = useParams();
    const navigate = useNavigate();

    useEffect(() => {
        const url = `${baseApiUrl}/contacts/${id}`;
        axios.get(url).then(
            responce => {
                setContact(responce.data);
            }
        ).catch(
            err => {
                navigate("/");
            }
        )
    }, [id, navigate]);


    return (
        <div className="container mt-5">

            <h2>Детали контакта</h2>
            <div className="mb-3">
                <label className="form-label">Имя: </label>
                <input
                    className="form-control"
                    type="text"
                    value={contact.name}
                    onChange={(e) => { }}
                />
            </div>

            <div className="mb-3">
                <label className="form-label">Email: </label>
                <input
                    className="form-control"
                    type="email"
                    value={contact.email}
                    onChange={(e) => { }}
                />
            </div>

            <button
                className="btn btn-primary me-2" onClick={(e) => { }}>
                Обновить
            </button>

            <button
                className="btn btn-danger me-2" onClick={(e) => { }}>
                Удалить
            </button>

            <button
                className="btn btn-secondary me-2" onClick={(e) => { }}>
                Назад
            </button>

        </div>
    )

}

export default ContactDetails;