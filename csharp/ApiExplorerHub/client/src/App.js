import axios from 'axios';
import React, {useState, useEffect} from "react";
import TableContact from "./layout/TableContant/TableContant";
import FormContact from "./layout/FormContact/FormContact";
import { Routes, Route, useLocation } from 'react-router-dom';
import ContactDetails from './layout/ContactDetails/ContactDetails';

const baseApiUrl = process.env.REACT_APP_API_URL;

const App = () => {

  const [contacts, setContacts] = useState([]);
  const location = useLocation();

  useEffect(() => {
    const url = `${baseApiUrl}/contacts`;
    axios.get(url).then(
      res => setContacts(res.data)
    );
  }, [location.pathname]);


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

  return (
    <div className="container mt-5">

      <Routes>
        <Route path='/' element={
          <div className="card">
            <div className="card-header">
              <h1>Список контактов</h1>
            </div>

            <div className="card-body">
              <TableContact contacts={contacts}/>  
              <FormContact addContact={addContact}/>
              
            </div>
          </div>
          } 
        />
        
        <Route path='contact/:id' element={<ContactDetails />} ></Route>
      </Routes>

    </div>
  );
}

export default App;
