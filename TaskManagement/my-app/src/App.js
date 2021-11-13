import './App.css';
import React from 'react'
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css';
// or less ideally
//import { Button } from 'react-bootstrap';

function App() {

  return (
    <div className="App">
      <header className="App-header">
      <style type="text/css">
    {`
    .btn-flat {
      background-color: purple;
      color: white;
    }

    .btn-xxl {
      padding: 1rem 1.5rem;
      font-size: 1.5rem;
    }
    `}
  </style>
      
      </header>
      <Button variant="flat" size="xxl">
    flat button
  </Button>
    </div>
  );
}

export default App;
