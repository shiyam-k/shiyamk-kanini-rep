import React from 'react';
import './App.css';
import e1 from './img/e1.png'
import e3 from './img/e6.jpg'
import e4 from './img/e7.avif'
import e5 from './img/e8.jfif'
import Navbar from './components/navbar';

class App extends React.Component  {
  constructor(props) {
    super(props);
    this.state = {
      employeeRecords : [
        {
          EId : "e101",
          EName : "Mathew",
          Img : e1,
          specialization : [
            {
            name:"React",
            type:"front-end"
            },
            {
            name:"No-sql",
            type:"back-end"
            },
            {
            name:"mssql",
            type:"backend-end"
            },
        ]
        },
        {
          EId : "e102",
          EName : "Mitchel",
          Img : e5,
          specialization : [
            {
            name:"angular",
            type:"front-end"
            },
            {
            name:"Rest-api",
            type:"back-end"
            },
            {
            name:"crypto",
            type:"blockchain"
            },
        ]
        },
        {
          EId : "e103",
          EName : "Merlin",
          Img : e3,
          specialization : [
            {
            name:"Html",
            type:"front-end"
            },
            
        ]
        },
        {
          EId : "e104",
          EName : "Becc",
          Img : e4,
          specialization : [
            {
            name:"spring",
            type:"back-end"
            },
            {
            name:"No-sql",
            type:"back-end"
            },
            {
            name:"mssql",
            type:"back-end"
            },
            {
              name:"swift",
              type:"ios"
              },
              
        ]
        },
        // {
        //   EId : "e5",
        //   EName : "Khabib",
        //   Img : e5
        // },
      ]
    };
  }
  render(){
    return (
      <div>
        <div>
          <Navbar e={this.state.employeeRecords}></Navbar>
        </div>
          <div className='e-view'>
          </div>
      </div>
    )
  }
  


}

export default App;
