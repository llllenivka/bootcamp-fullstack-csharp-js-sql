import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

// let h1Element = document.createElement("h1");
// h1Element.textContent = "HELLO";
// const root = document.getElementById("root");
// root.appendChild(h1Element);

const root = ReactDOM.createRoot(document.getElementById('root'));

const value = "Что-то есть";

const firstname = "Аделина";
const lastname = "Ш.";

const item = ["Элемент1", "Элемент2", "Элемент3", "Элемент4" ,"Элемент5", "Элемент6"];

root.render(
  <div>
    <h1>{value}</h1>

    <h1>{firstname + " " + lastname}</h1>

    <ul>
      {
        item.map(i => <li>{i}</li>)
      }
    </ul>

    <p>
      &copy; Авторские права мои {new Date().getFullYear()}
    </p>
  </div>
);
