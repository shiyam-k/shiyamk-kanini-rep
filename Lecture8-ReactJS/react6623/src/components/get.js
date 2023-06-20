import React, { useState, useEffect } from 'react';
import Pagenotfound from './pagenotfound';
import { Routes,Route, Link } from 'react-router-dom'
import axios from 'axios';
import update from '../img/edit.svg';
import del from '../img/delete.svg';
import add from '../img/add.svg'
import { Dialog, DialogTitle, DialogContent, Input, DialogActions, Button, FormLabel} from '@mui/material';
const bootstrapTable = `table table-dark table-hover table-bordered border-success table-striped text-center`;

const button = {
  background : 'transparent',
  border : 'none'
}

const img = {
  width : '50px',
  height : '50px'
}
function Get() {
  const [employee, setEmployee] = useState([]);
  const [e, setE] = useState([]);
  
  
  useEffect(() => {
    fetchEmployees();
  },[]);
  const[response, setResponse] = useState([false, []])
  
  const [open, setOpen] = React.useState(false);
  const [a, setA] = React.useState(false);

  const [d, setDeleteModal] = useState(false);
  
  const handleDeleteModal = (employee) => {
    setE(employee);
    setDeleteModal(true);
  };
  

  const handleClickOpen = (employee) => {
    setE(employee);
    setOpen(true);
  };
  const updateE = (ue) =>{
    //console.log(ue);
    setE(ue)
    //console.log(ue);
    setOpen(false)
  }
  const handleClose = (id) => {
  const updatedFirstName = document.getElementById('updateFName').value;
  const updatedLastName = document.getElementById('updateLName').value;
  const updatedDOJ = document.getElementById('updateDOJ').value;
  const updatedDOB = document.getElementById('updateDOB').value;
  const updatedQualifications = document.getElementById('updateQualifications').value;

    //console.log(updatedFirstName)

  const updatedEmployee = {
    employeeFirstName: updatedFirstName,
    employeLastName: updatedLastName,
    employeeDOJ: updatedDOJ,
    employeeDOB: updatedDOB,
    employeeQualifications: updatedQualifications,
    
  };

  updateE(updatedEmployee);
  updateEmployees(id, updatedEmployee)
  //console.log(e, updatedEmployee)
};

  
const cancelUpdate = () => {

  setOpen(false)
}
 

  const fetchEmployees = async () => {
    try {
      const response = await axios.get('https://localhost:5000/Employee/actions');
      //const data = await response.json();
      console.log(response)
      setEmployee(response.data.employee);
    } catch (error) {
      console.log('Error fetching hotels:', error);
    }
  };
  const updateEmployees = async (id, emp) =>{
    try {
      const response = await axios({
        method: 'put',
        url: `https://localhost:5000/Employee/actions/id?id=${id}`,
        data: emp
    });
      //const data = await response.json();
      //console.log(response.data)
      //setEmployee(response.data.employee);
      gotoResponse(response.data);
    } catch (error) {
      console.log('Error fetching Employees:', error);
      gotoResponse(error)
    }
  }

  const gotoResponse = (r) => {
    setResponse([true, r])
    console.log(r)
  }
  const responseClose = () => {
    setResponse([false, []])
  }
  const removeEmployees = async (id) =>{
    try {
      const response = await await axios.delete(`https://localhost:5000/Employee/actions/ID?id=${id}`)
      //const data = await response.json();
      //console.log(response.data)
      setDeleteModal(false)
      gotoResponse(response.data);

      //setEmployee(response.data.employee);
    } catch (error) {
      console.log('Error fetching Employees:', error);
      setDeleteModal(false)
      gotoResponse(error)
    }
  }

  const handleAddModal = () =>{
    setA(true)
  }

  const createEmployee = () =>{
    const updatedFirstName = document.getElementById('updateFName').value;
    const updatedLastName = document.getElementById('updateLName').value;
    const updatedDOJ = document.getElementById('updateDOJ').value;
    const updatedDOB = document.getElementById('updateDOB').value;
    const updatedQualifications = document.getElementById('updateQualifications').value;
    const newPassword = document.getElementById('password').value;
    const newEmployee = {
      employeeFirstName: updatedFirstName,
      employeLastName: updatedLastName,
      employeeDOJ: updatedDOJ,
      employeeDOB: updatedDOB,
      employeeQualifications: updatedQualifications,
      employeePassword : newPassword
      
    };
    addEmployee(newEmployee)
    
  }
  const addEmployee = async (ne) => {
    try {
      const resp = await axios.post('https://localhost:5000/Employee/actions', ne);
      //console.log(resp.data);
      setA(false)
      gotoResponse(resp.data);
  } catch (err) {
      // Handle Error Here
      //console.error(err);
      setA(false)
      gotoResponse(err)
  }
  }


  return (
    <div>
      <button className='btn btn-outline-success' onClick={() =>  handleAddModal()}><img src={add} style={img}></img></button>
      {employee && employee.length > 0 ? (
        <table className={bootstrapTable}>
        <thead>
          <tr >
            <th className='text-danger'>Employee Id</th>
            <th className='text-danger'>First name</th>
            <th className='text-danger'>Qualifications</th>
            <th className='text-danger'>Update</th>
            <th className='text-danger'>Delete</th>
          </tr>
        </thead>
        <tbody>
            {employee.map((e) => (
            <tr key={e.employeeId}>
              <td className='text-info'>{e.employeeId}</td>
              <td className='text-info'>{e.employeeFirstName}</td>
              <td className='text-info'>{e.employeeQualifications}</td>
              <td className='text-info'><button style={button} onClick={() => handleClickOpen(e)}><img src={update} style={img} ></img></button></td>
              <td className='text-info'><button style={button} onClick={() => handleDeleteModal(e)}><img src={del} style={img}></img></button></td>
            </tr>            
              ))}             
        </tbody>
      </table>)        
        : (
          <div >
          <nav >
              <ul>                  
                  <li><Link to={'/pagenotfound'} className='btn btn-outline-success navTab'>Reload</Link></li>
              </ul>
          </nav>          
      <Routes>        
        <Route path="/pagenotfound" element={<Pagenotfound></Pagenotfound>}></Route>  
      </Routes>
      </div>
      )}

    <Dialog open={d} onClose={() => setDeleteModal(false)}>
        <DialogTitle className='bg-dark text-danger'>Delete Employee {e == null ? '' : e.employeeId}</DialogTitle>
        <DialogContent className='bg-dark text-white '>
        </DialogContent>
        <DialogActions className='bg-dark text-white'>
          <Button onClick={handleDeleteModal}></Button>
          <button className='btn btn-outline-success' onClick={()=> removeEmployees(e.employeeId)}>Delete</button>
        </DialogActions>
      </Dialog>
      

      <Dialog open={open} onClose={() => setOpen(false)}>
        <DialogTitle className='bg-dark text-warning'>Update Employee {e == null ? '' : e.employeeId}</DialogTitle>
        <DialogContent className='bg-dark text-white '>
          <FormLabel className='text-white'>First Name</FormLabel>
          <Input className='form-control' defaultValue={e == null ? '' : e.employeeFirstName} id='updateFName' ></Input>
          <FormLabel className='text-white'>Last Name</FormLabel>
          <Input className='form-control' defaultValue={e == null ? '' : e.employeLastName} id='updateLName'></Input>
          <FormLabel className='text-white'>Date of Join</FormLabel>
          <Input className='form-control' defaultValue={e == null ? '' : e.employeeDOJ} type='date' id='updateDOJ'></Input>
          <FormLabel className='text-white'>Date of Birth</FormLabel>
          <Input className='form-control' defaultValue={e == null ? '' : e.employeeDOB} type='date' id='updateDOB'></Input>
          <FormLabel className='text-white'>Qualifications</FormLabel>
          <Input className='form-control' defaultValue={e == null ? '' : e.employeeQualifications} id='updateQualifications'></Input>
        </DialogContent>
        <DialogActions className='bg-dark text-white'>
          <Button onClick={cancelUpdate}></Button>
          <button className='btn btn-outline-success' onClick={()=> handleClose(e.employeeId)}>Update</button>
        </DialogActions>
      </Dialog>


      <Dialog open={a} onClose={() => setA(false)}>
        <DialogTitle className='bg-dark text-success'>Add New Employee {e == null ? '' : e.employeeId}</DialogTitle>
        <DialogContent className='bg-dark text-white '>
          <FormLabel className='text-white'>First Name</FormLabel>
          <Input className='form-control' id='updateFName' ></Input>
          <FormLabel className='text-white'>Last Name</FormLabel>
          <Input className='form-control' id='updateLName'></Input>
          <FormLabel className='text-white'>Date of Join</FormLabel>
          <Input className='form-control' type='date' id='updateDOJ'></Input>
          <FormLabel className='text-white'>Date of Birth</FormLabel>
          <Input className='form-control' type='date' id='updateDOB'></Input>
          <FormLabel className='text-white'>Qualifications</FormLabel>
          <Input className='form-control' id='updateQualifications'></Input>
          
          <FormLabel className='text-white'>Password</FormLabel>
          <Input className='form-control' id='password' type='password'></Input>
        </DialogContent>
        <DialogActions className='bg-dark text-white'>
          <Button onClick={cancelUpdate}></Button>
          <button className='btn btn-outline-success' onClick={()=> createEmployee()}>Add</button>
        </DialogActions>
      </Dialog>

      <Dialog open={response[0]} onClose={() => setResponse(false,[])}>
        <DialogTitle className='bg-dark text-success'>{(response[1] == null ? '' : response[1].message)}</DialogTitle>
        <DialogContent className='bg-dark text-white '>
          {/* <FormLabel className='bg-dark text-success'>{(response[1] == null ? '' : response[1].employee[0].employeeId)} updated</FormLabel> */}
        </DialogContent>
        <DialogActions className='bg-dark text-white'>
          <Button onClick={handleDeleteModal}></Button>
          <button className='btn btn-outline-success' onClick={() => setResponse(false,[])}>Proceed</button>
        </DialogActions>
      </Dialog>
    </div>
  );
}


  
export default Get;
