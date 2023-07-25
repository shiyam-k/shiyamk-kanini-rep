import React, { useState } from 'react';
import 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/styles/navbar.css'
import { Link } from 'react-router-dom'
import useAuth from '../authproviderComponent/authContext';
import ProfileImg from 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/assets/img/profile.svg'


const ProfileStyle = {
    width :'40px',
    height : '40px',
    cursor : 'pointer'
}


const Navbar = () => {
  const [collapseVisible, setCollapseVisible] = useState(false);

  const handleNavbarToggle = () => {
    setCollapseVisible(!collapseVisible);
  };

  const {auth} = useAuth()
  console.log(auth.loginLog)
  return (
    <div>
      <nav className="navbar navbar-primary" style={{backgroundColor : '#3AA6B9'}}>
        <div className="nav-flex">
          <button className="navbar-toggler" type="button" onClick={handleNavbarToggle} aria-controls="navbarToggleExternalContent">
            <span className="navbar-toggler-icon"></span>
          </button>
          <Link to={'/'}>
            <h3 className="text-dark head-link" style={{textDecoration :'none'}}>Employees Connect</h3>
          </Link>
          <Link to={'/navbarComponent/profilePage'}>
              {auth.loginLog.isLoggedIn ? 
                <div className="profile">
                    <img src={ProfileImg} style = {ProfileStyle} alt=''></img>            
                </div> 
                :
                <div className='nav-item'><Link to={'/loginComponent/loginPage'} className='nav-link'>Login</Link></div>
              }
          </Link>           
        </div>
      </nav>

      <div className={`collapse p-4${collapseVisible ? ' show' : ''}`} id="navbarToggleExternalContent">
      <div >
        <nav>
            <ul className='nav nav-tabs nav-fill'>
                <li className='nav-item'><Link to={'/homeComponent/homePage'} className='nav-link'>Home</Link></li>
                {
                  !auth.loginLog.isLoggedIn ?
                  <li className='nav-item'><Link to={'/loginComponent/loginPage'} className='nav-link'>Login</Link></li>              
                  :
                  <></>
                }

                <li className='nav-item'><Link to={'/aboutusComponent/aboutusPage'} className='nav-link'>About Us</Link></li>
            </ul>
        </nav>
       </div>
      </div>
    </div>
  );
};

export default Navbar;
