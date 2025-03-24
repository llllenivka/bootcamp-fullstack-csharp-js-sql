import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

// let h1Element = document.createElement("h1");
// h1Element.textContent = "HELLO";
// const root = document.getElementById("root");
// root.appendChild(h1Element);

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <div>
    <h1>Какой-то текст</h1>
    <ul>
      <li>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</li>
      <li>Nunc at enim ac nulla accumsan vulputate.</li>
      <li>Suspendisse ultricies tellus convallis, varius mi sed, dignissim ligula.</li>
    </ul>
  </div>
);
