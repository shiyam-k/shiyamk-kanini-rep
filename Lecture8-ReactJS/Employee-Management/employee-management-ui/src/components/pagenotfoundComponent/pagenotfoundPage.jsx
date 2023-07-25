import React from 'react'
import NotFoundImg from 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/assets/img/notfound.svg'
import { Link } from 'react-router-dom'
import { Stack } from '@mui/material'
import useAuth from '../authproviderComponent/authContext'

const unAuthStyle = {
    margin :'auto',
    width :'20%',
    position : 'relative',
    top : '150px'
}

const imgStyle = {
    width : '30%',
    height : '150px',

}
const PagenotfoundPage = () => {
    const {auth} = useAuth()
  return (
    <div style={unAuthStyle}>
        <Stack direction={'row'}>
            <img src={NotFoundImg} alt="" style={imgStyle}/>
            <Stack direction={'column'} alignItems={'center'} justifyContent={'center'}>
                <h4 className='text-warning'>Page Not Found</h4>
                {
                    auth.loginLog.isLoggedIn ?
                    <Link to={'/'} className='btn btn-outline-success' >Home</Link> :
                    <Link to={'/loginComponent/loginPage'} className='btn btn-outline-success' >To Login</Link>
                }
                </Stack>
        </Stack> 
    </div>
  )
}

export default PagenotfoundPage