import {React, useState} from 'react'


const bootstrapCard = `card bg-dark border-danger table-striped text-white`
const cardStyle = {
    width:"100%",
    display:"flex",
    flexDirection :"row",
    gap:"20px"
}
const imgStyle = {
    width:"50px",
    height : "50px",
    borderRadius:"50%" ,
    border : "2px solid red" 
  }
const EmployeeList =(props)=> {
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
        <div >
            <select
                className='form-control border-primary text-info filter-spec'
                id='filter'
                name='filter'
                value={selfil}
                onChange={selchange}>
                <option name='all' value={"all"}>All</option>
                <option name='front-end' value={"front-end"}>Front End</option>
                <option name='back-end' value={"back-end"}>Back End</option>
                <option name='blockchain' value={"blockchain"}>Blockchain</option>
                <option name='ios' value={"ios"}>ios</option>
  
              </select>
          <ul>
          {empfil.map((emp) => (
            <li key={emp.EId} data-type={emp.specialization.map((spec) => spec.type).join(' ')}>
              <img src={emp.Img}  alt="Employee Profile" style={imgStyle}/> {emp.EId} {emp.EName}
              {emp.specialization.map((spec, index) => (
                  <ul key={index} style={cardStyle}>
                    <li><span className='text-warning'>{spec.name}</span></li>
                    <li><span className='text-success'>{spec.type}</span></li>
                  </ul>
                ))}              
            </li>
          ))}
          </ul>
        </div>
    );
}

export default EmployeeList