import React from 'react'
import { Routes,Route, Link } from 'react-router-dom'
import EmployeesView from './employeeView'
import EmployeeCard from './employeeCard'
import EmployeeList from './list'
import Pagenotfound from './pagenotfound'
import MyForm from './fetchPost'
import '../components/employee.css'

const LazyGet = React.lazy(() => import('./get'));


const navStyle = {
    height:"100px",
    width:"100%",
    backgroundColor : "#F2BE22",
    color: "white",
}
const Nav = {
    width:"25%",
    display : "flex",
    flexDirection : "row",
    justifyContent:"space-between"
}
const mainContent = {
    margin: "auto",
    width: "50%",
    position: "relative",
    top: "100px"
}
function Navbar(props) {
  return (
    <div >
        <nav style={navStyle}>
            <ul style={Nav}>
                <li><Link to={'/employeeView'} className='btn btn-outline-danger navTab'>Table</Link></li>
                <li><Link to={'/employeeCard'} className='btn btn-outline-danger navTab'>Card</Link></li>
                <li><Link to={'/list'} className='btn btn-outline-danger navTab'>List</Link></li>
                <li><Link to={'/get'} className='btn btn-outline-danger navTab'>Get</Link></li>
                <li><Link to={'/fetchPost'} className='btn btn-outline-danger navTab'>Fetch</Link></li>
            </ul>
        </nav>
        
    <Routes className={mainContent}>
      <Route path="/employeeView" element={<EmployeesView e={props}/>}></Route>
      <Route path="/employeeCard" element={<EmployeeCard e={props}/>}></Route>
      <Route path="/list" element={<EmployeeList e={props}/>}></Route>
      <Route path="/get" element={<React.Suspense>
        <LazyGet/>
      </React.Suspense>}></Route>
      <Route path="/fetchPost" element={<MyForm></MyForm>}></Route>

      <Route path="*" element={<Pagenotfound></Pagenotfound>}></Route>




    </Routes>
    
    </div>

    )
}

export default Navbar