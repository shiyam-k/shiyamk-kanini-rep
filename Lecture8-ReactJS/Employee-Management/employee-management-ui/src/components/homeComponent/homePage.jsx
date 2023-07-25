import React from 'react';
import 'E:/Kanini/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/styles/homePage.css';
import Stack from '@mui/material/Stack'
import Product from 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/assets/img/product.svg'
import Data from 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/assets/img/data.svg'
import Service from 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/assets/img/service.svg'

const HomePage = () => {
  return (
    <div className="container">
      <div className="jumbotron">
        <h1>Welcome to Kanini Software Solutions</h1>
        <p className="lead">Transforming businesses with innovative software solutions</p>
      </div>

      <div className="services">
        <h2>Our Services</h2>
        <div className="row">
          <div className="col-md-4">
            <div className="service-card">
              <h3>Product Engineering</h3>
              <Stack direction={'row'} justifyContent={'space-between'}>
                <img src={Product} alt='' width={'50px'} height={'50px'}></img>
                <p>
                    We specialize in building scalable and robust software products tailored to meet your unique business requirements.
                </p>
              </Stack>
            </div>
          </div>
          <div className="col-md-4">
            <div className="service-card">
              <h3>Data Science</h3>
              <Stack direction={'row'} justifyContent={'space-between'}>
                <img src={Data} alt=""  width={'50px'} height={'50px'}/>
                <p>
                    Our data science experts can help you leverage data to gain valuable insights, make informed decisions, and drive business growth.
                </p>
              </Stack>
            </div>
          </div>
          <div className="col-md-4">
            <div className="service-card">
              <h3>ServiceNow</h3>
              <Stack direction={'row'} justifyContent={'space-between'}>
                <img src={Service} alt="" width={'50px'} height={'50px'} />
                <p>
                    We provide comprehensive ServiceNow solutions to streamline your IT service management processes and enhance operational efficiency.
                </p>
              </Stack>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default HomePage;
