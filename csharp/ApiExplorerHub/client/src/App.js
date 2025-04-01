import axios from 'axios';
import React, {useState, useEffect} from "react";
import TableContact from "./layout/TableContant/TableContant";
import FormContact from "./layout/FormContact/FormContact";

const baseApiUrl = process.env.REACT_APP_API_URL;

const App = () => {

  const [contacts, setContacts] = useState([]);

  const url = `${baseApiUrl}/contacts`;
  useEffect(() => {
    axios.get(url).then(
      res => setContacts(res.data)
    );
  }, []);


  const addContact = (contactName, contactEmail) => {
    
    const item = {
      name: contactName, 
      email:contactEmail
    };

    const url = `${baseApiUrl}/contacts`;
    console.log(url);
    axios.post(url, item).then(
      response => setContacts([...contacts, response.data])
    );
  };


    

  const deleteContact = (id) => {
    const url = `${baseApiUrl}/contacts/${id}`;
    axios.delete(url, id)
    setContacts(contacts.filter(item => item.id !== id));
  }


  return (
    <div className="container mt-5">
      <div className="card">
        <div className="card-header">
          <h1>Список контактов</h1>
        </div>

        <div className="card-body">
          <TableContact 
            contacts={contacts}
            deleteContact={deleteContact}
          />  
          <FormContact addContact={addContact}/>
          
        </div>
      </div>

    </div>
  );
}

export default App;
