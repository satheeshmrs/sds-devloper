import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

const App = () => {
  const [loginAttempts, setLoginAttempts] = useState([]);

  const handleSubmit =({login, password})=>{
    console.log({login, password});
    const loginAttempt= {
      login,
      password,
      id: Date.now()
    };

    setLoginAttempts(loginAttempts=>[...loginAttempts, loginAttempt]);
    console.log(loginAttempts);
  }

  return (
    <div className="App">
      <LoginForm onSubmit={({ login, password }) => handleSubmit({ login, password })} />
      <LoginAttemptList attempts={loginAttempts} />
    </div>
  );
};

export default App;
