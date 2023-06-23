import React, { useState, useEffect } from 'react';
import { Dialog, DialogTitle, DialogContent, DialogActions} from '@mui/material';
const bootstrapTable = `table table-dark table-hover table-bordered border-success table-striped text-center`;

function MyForm() {
  const[response, setResponse] = useState([false, []])

    const [formData, setFormData] = useState({
        userName: '',
        password: ''
    });

    const handleInputChange = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };
    const gotoResponse = (r) => {
        setResponse([true, r])
        console.log(r)
      }

    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(JSON.stringify(formData))
        // Post the form data to the API
        fetch('https://localhost:5000/Authenticate/actions/Register', {
            method: 'POST',
            body: JSON.stringify(formData),
            headers: {
                'Content-Type': 'application/json'
            }
        })
            .then(response => response.json())
            .then(data => {
                // Handle the API response
                console.log('API response:', data);
                gotoResponse(data)
            })
            .catch(error => {
                console.error('Error:', error);
                gotoResponse(error)
            });
    };




    return (
        <div style={{margin : 'auto', width : '15%', position : 'relative', top : '100px'}}>
            <form onSubmit={handleSubmit}>
                <div className="form-group">
                    <label>
                        User Name:
                        <input type="text" className="form-control" name="userName" value={formData.userName} onChange={handleInputChange} />
                    </label>
                </div>
                <br />
                <div className="form-group">
                    <label>
                        Password:
                        <input type="password" className="form-control" name="password" value={formData.password} onChange={handleInputChange} />

                    </label>
                </div>
                <br />
                <button type="submit" className="btn btn-success">Submit</button>
            </form>
             
            <Dialog open={response[0]} onClose={() => setResponse(false,[])}>
                <DialogTitle className='bg-dark text-success'>{(response[1] == null ? '' : response[1].message)}</DialogTitle>
                <DialogContent className='bg-dark text-white '>
                {/* <FormLabel className='bg-dark text-success'>{(response[1] == null ? '' : response[1].employee[0].employeeId)} updated</FormLabel> */}
                </DialogContent>
                <DialogActions className='bg-dark text-white'>
                <button className='btn btn-outline-success' onClick={() => setResponse(false,[])}>Proceed</button>
                </DialogActions>
            </Dialog>
        </div>
    );
}

export default MyForm;