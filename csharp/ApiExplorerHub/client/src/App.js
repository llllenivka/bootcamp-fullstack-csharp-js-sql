import axios from 'axios';
import React, {useState, useEffect} from "react";
import TableContact from "./layout/TableContant/TableContant";
import AppendContact from './layout/FormContact/AppendContact';
import { Routes, Route, useLocation, Link } from 'react-router-dom';
import ContactDetails from './layout/ContactDetails/ContactDetails';
import Pagination from './layout/Pagination/Pagination';

const baseApiUrl = process.env.REACT_APP_API_URL;

const App = () => {

  const [contacts, setContacts] = useState([]);
  const location = useLocation();
  const [currentPage, setCurrenPage] = useState(1)
  const [totalPages, setTotalPages] = useState(0);
  const [pageSize] = useState(10);
  const [updateTrigger, setUpdateTrigger] = useState(0);

  const handleUpdateTrigger = () => {
    setUpdateTrigger(updateTrigger + 1);
  }

  const handlePageChange = (pageNumber) => {
    setCurrenPage(pageNumber);
  }

  useEffect(() => {
    const url = `${baseApiUrl}/contacts/page?pageNumber=${currentPage}&pageSize=${pageSize}`;
    axios.get(url).then(
      res => {
        setContacts(res.data.contacts);
        setTotalPages(Math.ceil(res.data.totalCount / pageSize));
      } 
    );
  }, [currentPage, pageSize, location.pathname]);




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
              <Pagination 
                currentPage={currentPage}
                totalPages={totalPages}
                onPageChange={ handlePageChange}
              />
              
              <Link to="/append"
                className='btn btn-success mt-3'
              >
                Добавть контакт
              </Link>
            </div>
          </div>
          } 
        />
        
        <Route path='contact/:id' element={<ContactDetails onUpdate = {handleUpdateTrigger}/>} ></Route>
        <Route path='append' element={<AppendContact />} ></Route>
      </Routes>

    </div>
  );
}

export default App;
