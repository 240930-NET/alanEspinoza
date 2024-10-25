import React, { Fragment, useState} from 'react';
import axios from 'axios';

function Registration(){
    const[firstName, setFirstName] = useState('');
    const[lastName, setLastName] = useState('');
    const[userName, setUserName] = useState('');
    const[password, setPassword] = useState('');

    const handleFirstNameChange = (value) => {setFirstName(value);}
    const handleLastNameChange = (value) => {setLastName(value);}
    const handleUserNameChange = (value) => {setUserName(value);}
    const handlePasswordChange = (value) => {setPassword(value);}

    const handleSave = () => {
        const data ={
            FirstName : firstName,
            Lastname : lastName,
            UserName : userName,
            Password : password
        };
    const url ='http://10.0.0.250:5247/api/User/AddNewUser/';
    axios.post(url,data).then((result) =>{
    alert(result.data);
    }).catch((error)=>{alert(error); 
    })

    }


    return(
        <Fragment>
        <div><h3>Registration</h3></div>
        <label> First Name</label>
        <input type = "text" id = "FirstName" placeholder='Enter First Name' onChange={(e) =>handleFirstNameChange(e.target.value)}/><br></br><br></br>
        <label> Last Name</label>
        <input type = "text" id = "LastName" placeholder='Enter Last Name' onChange={(e) =>handleLastNameChange(e.target.value)}/><br></br><br></br>
        <label> Username</label>
        <input type = "text" id = "UserName" placeholder='Enter Username' onChange={(e) =>handleUserNameChange(e.target.value)}/><br></br><br></br>
        <label> Password</label>
        <input type = "text" id = "Password" placeholder='Enter Password' onChange={(e) =>handlePasswordChange(e.target.value)}/><br></br><br></br>
        <button onClick={() => handleSave()}>Register</button><br></br>
        </Fragment>
    )


}

export default Registration;