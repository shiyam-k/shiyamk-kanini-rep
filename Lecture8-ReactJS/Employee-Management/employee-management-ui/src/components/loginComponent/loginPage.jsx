import React, { useState, lazy, Suspense, useEffect } from 'react';
import axios from 'axios';
import useAuth from '../authproviderComponent/authContext';
import jwt_decode from 'jwt-decode';
import { useLocation, useNavigate } from 'react-router-dom';
const Typography = lazy(() => import('@mui/material/Typography'));
const Modal = lazy(() => import('@mui/material/Modal'));
const Stack = lazy(() => import('@mui/material/Stack'));

const LoginPage = () => {
  const {updateAuth} = useAuth()    
  const navigate = useNavigate()
  const location = useLocation()
  const from = location.state?.from?.pathName || '/'

  const [user, setUser] = useState({
    loginId: '',
    password: ''
  });

  const handleInputChange = (event) => {
    const { name, value } = event.target;
    setUser((prevUser) => ({
      ...prevUser,
      [name]: value
    }));
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    authenticateEmployee(user);
  };

  const style = {
    position: 'absolute',
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    width: 400,
    border: '2px solid #000',
    boxShadow: 24,
    p: 4,
    backgroundColor : '#27374D',
  };

  const LoginStyle = {
    position : 'relative',
    top : '75px',
    margin : 'auto',
    width : '25%'
  }
  const [responseModal, setResponseModal] = React.useState(false);
  const handleResponseOpen = () => setResponseModal(true);
  const handleResponseClose = () => setResponseModal(false);

  const [response, setResponse] = useState({});
  const handleSetResponse = (data) => {
    setResponse(data);
  };

  const Proceed = () =>{
    console.log(from)
    navigate(from, {replace : true})
  }  

  const authenticateEmployee = async (employee) => {
    try {
      const data = await axios.post(
        'https://localhost:5000/Authicate/actions/login',
        employee,
        { headers: { 'Content-Type': 'application/json' } }
      )      
      handleSetResponse(data.data);
      updateAuth(data.data.loginLog.sessionId, data.data.loginLog.loginId, data.data.loginLog.token, data.data.loginLog.isLoggedIn, data.data.role);
      console.log(data.data)
      // localStorage.setItem('loginId', user.loginId)
      // localStorage.setItem('password', user.password)
      // localStorage.setItem('token', Token)
      // localStorage.setItem('sessionId', SessionId)
      // localStorage.setItem('isLoggedIn', true)
      handleResponseOpen(true);
    } catch (error) {
      handleSetResponse(error);
      console.log('Error fetching Employees:', error);
      handleResponseOpen(true);
    }
  };

  return (
    <div style={LoginStyle}>
      <form className="card border-primary" style={{ width: '25rem' }} onSubmit={handleSubmit}>
        <div className="card-head border-primary">
          <h3 className="card-text text-center text-white">Login</h3>
        </div>
        <div className="card-body text-white">
          <label htmlFor="employeeId">Employee Id :</label>
          <input
            type="text"
            className="form-control"
            name="loginId"
            value={user.loginId}
            onChange={handleInputChange}
            autoComplete='off'
            required
            title="Please"
          />
          <label htmlFor="password">Password :</label>
          <input
            type="password"
            className="form-control"
            name="password"
            value={user.password}
            onChange={handleInputChange}
            required
            title="Please"
          />
        </div>
        <div className="card-footer text-center">
          <button type="submit" className="btn btn-outline-primary" >
            Login            
          </button>
        </div>
      </form>
      <Suspense fallback={
          <div className="d-flex justify-content-center" style={{opacity:'.7'}} direction={'column'}>
            <div className="spinner-border text-primary" role="status">
            </div>
            <span className="sr-only ">Loading</span>
          </div>}>
        <Modal
          open={responseModal}
          onClose={handleResponseClose}
          aria-labelledby={"text-response-message" || "text-error-message"}
          aria-describedby={"text-response-token" || 'text-error-token'}
        >
          {response.status !== null && response.status === true ? (
            <Stack sx={style} alignItems="center" justifyContent="space-evenly"  className='rounded'>
              <Typography id="text-response-message" variant="h6" className="text-success">
                {response.message}
              </Typography>
              <Typography id="text-response-token" className="text-primary">
              </Typography>
              <button className="btn btn-outline-success" onClick={Proceed}> Proceed</button>
            </Stack>
          ) : (
            <Stack sx={style} alignItems="center" justifyContent="space-evenly" className='rounded'>
              <Typography
                id="text-erroe-message"
                variant="h5"
                component="h2"
                className={response.status !== null && response.status === true ? 'text-success' : 'text-warning'}
              >
                {response.status !== null && response.status === true ? response.message : response.message}
              </Typography>
              <Typography
                id="text-error-token"
                className={response.status !== null && response.status === true ? 'text-success text-center' : 'text-danger text-center'}
              >
                {response.status !== null && response.status === true ? '' : response.name}
              </Typography>
              <button className="btn btn-outline-danger" onClick={handleResponseClose}> Go Back</button>
            </Stack>
          )}
        </Modal>
      </Suspense>
    </div>
  );
};

export default LoginPage;
