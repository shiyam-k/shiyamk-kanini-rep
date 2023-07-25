import React from 'react';
import 'E:/KANINI/Lecture8-ReactJS/Employee-Management/employee-management-ui/src/styles/aboutusPage.css';
import useAuth from '../authproviderComponent/authContext';

const AboutUsPage = () => {
  const {auth} = useAuth()
  return (
    <div className="container">
      <div className="about-us">
        <h2>About Us</h2>
        <p className="lead">
          Kanini Software Solutions is a leading software development company specializing in providing innovative solutions for businesses.
        </p>
        <p>
          Our mission is to empower organizations with cutting-edge technology and help them achieve their goals efficiently and effectively.
        </p>
        <p>
          With a team of highly skilled professionals and a strong focus on customer satisfaction, we strive to deliver top-notch software solutions that drive growth and success for our clients.
        </p>
        <p>
          At Kanini Software Solutions, we believe in continuous learning, collaboration, and delivering exceptional value to our clients. We are dedicated to staying at the forefront of technological advancements and leveraging the latest tools and frameworks to build robust and scalable software applications.
        </p>
        <p>
          Contact us today to explore how our solutions can transform your business and propel it towards greater heights.
        </p>
      </div> 
    </div>
  );
};

export default AboutUsPage;
