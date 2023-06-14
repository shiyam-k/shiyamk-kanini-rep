import React from 'react'
import notfound from '../img/construction.svg'
const st = {
    margin : 'auto',
    width:'500px',
    position:'relative',
    top:'200px',
    borderRadius : '10px',
    textAlign : 'center',
    backgroundColor : '#0E2954',
    color : 'red'

}
function Pagenotfound() {
  return (
    <div style={st}>
        <img src={notfound}></img>
        <marquee behavior="scroll" direction="left" className='bg-dark text-danger'>Requested URL is not available or under construction</marquee>

    </div>
  )
}

export default Pagenotfound