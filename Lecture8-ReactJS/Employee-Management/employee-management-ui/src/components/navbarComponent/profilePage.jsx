import React, { useEffect, useState } from 'react';
import useAuth from '../authproviderComponent/authContext';
import axios from 'axios';
import { Stack, Typography } from '@mui/material';
import LogoutComponent from './logoutComponent';

const profileStyle = {
  position : 'relstive',
  top : '100px',
  margin : 'auto',
  width : '50%',
  height : '90%'
}
const innerProfileStyle = {
  margin : 'auto',
  width : '90%',
  height : '90%'
}

const ProfilePage = () => {
  const { auth } = useAuth();
  const [profile, setProfile ] = useState();
  useEffect(() => {
    const getProfile = async () => {
      try {
        const response = await axios.get(
          `https://localhost:5000/Profile/actions?SId=${auth.loginLog.sessionId}`,
          {
            headers: {
              Authorization: `Bearer ${auth.loginLog}`,
            },
          }
        );
        console.log(response.data);
        setProfile(response.data);
      } catch (error) {
        console.log(error);
      }
    };

    getProfile();
  }, [auth.loginLog.sessionId]);

  return (
    <div >
      {
      profile != null && profile.status === true ? 
          <div className='card border border-primary text-center' style={profileStyle}>
            <h4 className='card-head' style={{color : '#E7B10A'}}>{profile.message}</h4>
            <Stack className='card border border-primary text-center mb-3' style={innerProfileStyle} direction={'row'} justifyContent={'center'}>
              <div className='col-md-4'>
                <img className="img-fluid rounded-start" style={{height:'100%'}} src={profile.employeeProfile.profileImgURL} alt=''/>
              </div>
              <div className='col-md-8' >
                <Stack className='card-body' alignItems={'flex-start'} direction={'column'} justifyContent={''}>
                  <Stack direction={'row'} alignItems={'center'}  justifyContent={'space-between'}>
                    <Typography variant='p' >Employee Id : </Typography>
                    <Typography variant='p' className='text-success'>{profile.employeeProfile.employeeId}</Typography>
                  </Stack>
                  <Stack direction={'row'} alignItems={'center'} justifyContent={'space-between'}>
                    <Typography variant='p' >Employee Name : </Typography>
                    <Typography variant='p' className='text-success'>{profile.employeeProfile.employeeFirstName} {profile.employeeProfile.employeLastName}</Typography>
                  </Stack>
                  <Stack direction={'row'} alignItems={'center'}  justifyContent={'space-evenly'}>
                    <Typography variant='p' >Employee DOB : </Typography>
                    <Typography variant='p' className='text-success'>{profile.employeeProfile.employeeDOB}</Typography>
                  </Stack>
                  <Stack direction={'row'} alignItems={'flex-start'} justifyContent={'space-between'}>
                    <Typography variant='p' >Employee DOJ : </Typography>
                    <Typography variant='p' className='text-success'>{profile.employeeProfile.employeeDOJ}</Typography>
                  </Stack>
                  <Stack direction={'row'}  alignItems={'flex-start'}  justifyContent={'space-between'}>
                    <Typography variant='p' >Employee Qualification : </Typography>
                    <Typography variant='p' className='text-success'>{profile.employeeProfile.employeeQualifications}</Typography>
                  </Stack>
                  <Stack direction={'row'} alignItems={'flex-start'}  justifyContent={'space-between'} flexWrap={'wrap'}>
                    <Typography variant='p' >Employee Specialization : </Typography>
                    <Typography variant='p' className='text-success'>{profile.employeeProfile.specialization}</Typography>
                  </Stack>
                  <Stack direction={'row'} alignItems={'flex-start'} justifyContent={'space-between'} flexWrap={'wrap'}>
                    <Typography variant='p'>Employee Skills:</Typography>
                    {profile.employeeProfile.skills != null && profile.employeeProfile.skills.length > 0 ? (
                      profile.employeeProfile.skills.map((skill, index) => (
                        <Typography key={index} className='text-success'>  {skill},</Typography>
                      ))
                    ) : (
                      <Typography className='text-danger'>None</Typography>
                    )}
                  </Stack>
                  <LogoutComponent></LogoutComponent>
                </Stack>
              </div>
            </Stack>
          </div>
          :
          <div className='text-danger'>
            <p>Error Occured... in server side </p>
            <p>{}</p>
          </div>
      }
    </div>
  );
};

export default ProfilePage;
