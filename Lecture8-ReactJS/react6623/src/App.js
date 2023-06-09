import { useState } from 'react';
import React from 'react';
import './App.css';
import e1 from './img/e1.png'
import e3 from './img/e6.jpg'
import e4 from './img/e7.avif'
import e5 from './img/e8.jfif'



const employeeRecords = [
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


const bootstrapTable = `table table-dark table-hover table-bordered border-success table-striped`
const imgStyle = {
  width:"50px",
  height : "50px",
  borderRadius:"50%" ,
  border : "4px solid green" 
}




const EmployeesView = () => {
  const [selfil, setfil] = useState("all");

  const selchange = (e) => {
    console.log(e.target.value)
    setfil(e.target.value);
  };

  const empfil = employeeRecords.filter((emp) => {
    if (selfil === "all") {
      return true;
    } else {
      return emp.specialization.some((spec) => spec.type === selfil);
    }
  });

  return (
    <table className={bootstrapTable}>
      <thead>
        <tr>
          <th>Profile</th>
          <th>EID</th>
          <th>EName</th>
          <th>
            <select
              className='form-control bg-dark text-white filter-spec'
              id='filter'
              name='filter'
              value={selfil}
              onChange={selchange}
            >
              <option name='all' value={"all"}>All</option>
              <option name='front-end' value={"front-end"}>Front End</option>
              <option name='back-end' value={"back-end"}>Back End</option>
              <option name='blockchain' value={"blockchain"}>Blockchain</option>
              <option name='ios' value={"ios"}>ios</option>

            </select>
          </th>
        </tr>
      </thead>
      <tbody>
        {empfil.map((emp) => (
          <tr key={emp.EId}>
            <td><img src={emp.Img} style={imgStyle} alt="Employee Profile" /></td>
            <td>{emp.EId}</td>
            <td>{emp.EName}</td>
            <td className='spec' data-type={emp.specialization.map((spec) => spec.type).join(' ')}>
              {emp.specialization.map((spec, index) => (
                <ul key={index}>
                  <li><span className='text-info'>{spec.name}</span></li>
                  <li><span className='text-warning'>{spec.type}</span></li>
                </ul>
              ))}
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};


class App extends React.Component  {
  render(){
    return (
       <div className='e-view'>
          <EmployeesView ></EmployeesView>
       </div>
    )
  }
  

  // BuildTable(){
  //   return (<EmployeesView employees={employeeRecords}></EmployeesView>)
  // }
  // CallEmployee1(){
  //   return (<EmployeesView employee={employeeRecords[2]}></EmployeesView>);
  // }
  // CallEmployee2(){
  //   return (<EmployeesView employee={employeeRecords[1]}></EmployeesView>);
  // }
  // CallEmployee3(){
  //   return (<EmployeesView employee={employeeRecords[3]}></EmployeesView>);
  // }
}

export default App;
