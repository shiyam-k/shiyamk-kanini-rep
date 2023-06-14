import {React, useState} from 'react'


const bootstrapCard = `card bg-dark border-danger table-striped text-white`
const cardStyle = {
    width:"100%",
    display:"flex",
    flexDirection :"row",
    gap:"20px"
}
const imgStyle = {
    width:"200px",
    height : "200px",
    borderRadius:"50%" ,
    border : "4px solid green" 
  }
const EmployeeCard =(props)=> {
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
                className='form-control bg-info text-white filter-spec'
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
          <div style={cardStyle}>
          {empfil.map((emp) => (
            <div key={emp.EId} className={[bootstrapCard]} >
              <div className='text-center'><img src={emp.Img}  alt="Employee Profile" style={imgStyle}/></div>
              <div className='text-center'>{emp.EId}</div>
              <div className='text-center'>{emp.EName}</div>
              <div className='spec' data-type={emp.specialization.map((spec) => spec.type).join(' ')}>
                {emp.specialization.map((spec, index) => (
                  <ul key={index} style={cardStyle}>
                    <li><span className='text-info'>{spec.name}</span></li>
                    <li><span className='text-warning'>{spec.type}</span></li>
                  </ul>
                ))}
              </div>
            </div>
          ))}
          </div>
        </div>
    );
}

export default EmployeeCard