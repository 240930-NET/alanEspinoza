import React, { Fragment } from 'react';

function Login(){

    return(
        <Fragment>
        <div><h3>Login</h3></div>
        <label> Username</label>
        <input type = "text" id = "UserName" placeholder='Enter Username'/><br></br><br></br>
        <label> Password</label>
        <input type = "text" id = "Password" placeholder='Enter Password'/><br></br><br></br>
        <button>Login</button>
        </Fragment>
    )


}

export default Login;