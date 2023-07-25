import { createContext, useState } from 'react';

const AuthContext = createContext({});

export const Authprovider = ({ children }) => {
  const [auth, setAuth] = useState({
    loginLog : {
      sessionId : null,
      loginId : null,
      token : null,
      isLoggedIn : false,
      role : null
    }
  });


  const updateAuth = (sId, loginid, jwttoken, isloggedin, r) => {
    setAuth({
      loginLog : {
        sessionId : sId,
        loginId : loginid, 
        token : jwttoken ,
        isLoggedIn : isloggedin,
        role : r
      }
    });
  };

  return (
    <AuthContext.Provider value={{ auth, updateAuth }}>
      {children}
    </AuthContext.Provider>
  );
};

export default AuthContext;
