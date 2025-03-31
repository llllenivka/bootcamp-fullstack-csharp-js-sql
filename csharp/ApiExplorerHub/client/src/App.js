import axios from 'axios';
import React, {useState} from "react";
import TableContact from "./layout/TableContant/TableContant";
import FormContact from "./layout/FormContact/FormContact";

const App = () => {
  const url = "http://localhost:5113/api/ContactManagment/contacts";
  axios.get(url).then(
    res => console.log(res.data)
  );
  const [contacts, setContacts] = useState(
    [
      {id:1, name:'Имя 1', email:'email1@mail.ru'},
      {id:2, name:'Имя 2', email:'email2@mail.ru'},
      {id:3, name:'Имя 3', email:'email3@mail.ru'},
    ]
  );


  const addContact = (contactName, contactEmail) => {
    const newId = contacts.length > 0 ? 
    (
      contacts
      .sort((x, y) => x.id - y.id)[contacts.length - 1]
      .id + 1
    ) : 1;
    
    const item = {
      id: newId, 
      name: contactName, 
      email:contactEmail
    };

    setContacts([...contacts, item]); 
  };

  const deleteContact = (id) => {
    setContacts(contacts.filter(item => item.id != id));
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
