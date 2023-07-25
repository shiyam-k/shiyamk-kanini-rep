import React from 'react'
import unAuthBg from 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/assets/img/unauthbg.svg'
import barrierBg from 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/assets/img/barrier.svg'
import { Link } from 'react-router-dom'
import { Stack } from '@mui/material'
import useAuth from '../authproviderComponent/authContext'

const unAuthStyle = {
    margin :'auto',
    width :'30%',
    position : 'relative',
    top : '150px'
}

const imgStyle = {
    width : '30%',
    height : '150px',

}

const Unauthorized = () => {
    const {auth} = useAuth()
  return (
    <div style={unAuthStyle}>
        {auth.loginLog.token == null ? 
            <Stack direction={'row'}>
                <img src={barrierBg} alt="" style={imgStyle}/>
                <Stack direction={'column'} alignItems={'center'} justifyContent={'center'}>
                    <h4 className='text-warning'>Session has been expired</h4>
                    <Link to={'/loginComponent/loginPage'} className='btn btn-outline-success' >Goto Login</Link>
                </Stack>
            </Stack> : 
            <div>
                <Stack direction={'row'}>
                    <img src={unAuthBg} alt="" style={imgStyle}/>
                    <Stack direction={'column'} alignItems={'center'} justifyContent={'center'}>
                        <h4 className='text-warning'>Unauthorized Access!</h4>
                    </Stack>
                </Stack>

            </div>
        }
    </div>
  )
}

export default Unauthorized