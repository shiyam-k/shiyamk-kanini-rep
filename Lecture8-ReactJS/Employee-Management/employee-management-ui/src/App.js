import React from 'react';
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';
import '../node_modules/bootstrap/dist/js/bootstrap.bundle.js';
import LoginPage from './components/loginComponent/loginPage';
import Navbar from './components/navbarComponent/navbar';
import { Routes, Route } from 'react-router-dom';
import './App.css';
import AboutUsPage from './components/aboutusComponent/aboutusPage';
import HomePage from './components/homeComponent/homePage';
import RequireAuth from './components/authproviderComponent/RequireAuth';
// import Unauthorized from './components/unauthorizedComponent/unauthorizedPage';
const Unauthorized = React.lazy(() => import('./components/unauthorizedComponent/unauthorizedPage'));
const LazyProfile = React.lazy(() => import('./components/navbarComponent/profilePage'));
const PageNotFound = React.lazy(() => import('./components/pagenotfoundComponent/pagenotfoundPage'))
const App = () => {
  return (
    <div>
      <Navbar />
      <div className='main-content'>
        <Routes>
          <Route path='/' element={<HomePage />} />
          <Route path='/homeComponent/homePage' element={<HomePage />} />
          <Route path='/loginComponent/loginPage' element={<LoginPage />} />
          <Route path='/unauthorizedComponent/unauthorizedPage' element={
              <React.Suspense
                fallback={
                  <div className='d-flex justify-content-center' style={{ opacity: '.7' }} direction={'column'}>
                    <div className='spinner-border text-primary' role='status'></div>
                    <span className='sr-only'>Loading</span>
                  </div>
                }
              >
                <Unauthorized />
              </React.Suspense>
            } />
          <Route element={<RequireAuth allowedRoles={['roleid006']}/>}>
            <Route path='/aboutusComponent/aboutusPage' element={<AboutUsPage />}/>
            
          </Route>
          <Route element={<RequireAuth allowedRoles={['roleid006','roleid007','roleid008', 'roleid009', 'roleid010','ROLE001' ]}/>}>
            <Route path='/navbarComponent/profilePage' element={
                <React.Suspense
                  fallback={
                    <div className='d-flex justify-content-center' style={{ opacity: '.7' }} direction={'column'}>
                      <div className='spinner-border text-primary' role='status'></div>
                      <span className='sr-only'>Loading</span>
                    </div>
                  }
                >
                  <LazyProfile />
                </React.Suspense>
              } />
            
          </Route>
          <Route path='*' element={
              <React.Suspense
                fallback={
                  <div className='d-flex justify-content-center' style={{ opacity: '.7' }} direction={'column'}>
                    <div className='spinner-border text-primary' role='status'></div>
                    <span className='sr-only'>Loading</span>
                  </div>
                }
              >
                <PageNotFound />
              </React.Suspense>
            } />
        </Routes>
      </div>
    </div>
  );
};

export default App;
