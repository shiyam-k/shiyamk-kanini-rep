import React from 'react';
import { add } from './add';


function BtnTestComponent() {
  const handleClick = () => {
    alert('sum of 50 and 75 is : '+ add(50, 75))
    console.log(add(50, 75))
  };
  return (
    <div>
      <button className='btn btn-outline-primary' title='btn' onClick={handleClick}>Click me</button>
    </div>
  );
}

export { BtnTestComponent };
