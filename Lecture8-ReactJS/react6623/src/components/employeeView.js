import {React, useState} from "react";


  
  
  const bootstrapTable = `table table-dark table-hover table-bordered border-success table-striped text-center`
  const imgStyle = {
    width:"50px",
    height : "50px",
    borderRadius:"50%" ,
    border : "4px solid green" 
  }
 
const EmployeesView = (props) => {
    const [selfil, setfil] = useState("all");
  
    const selchange = (e) => {
      console.log(e.target.value)
      setfil(e.target.value);
    };
  
    const empfil = props.e.e.filter((emp) => {
      if (selfil === 'all') {
        return true;
      } else {
        return emp.specialization.some((spec) => spec.type === selfil);
      }
    });
  
    return (
      <table className={bootstrapTable} >
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
  
  export default EmployeesView