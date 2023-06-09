import React from "react";

export default function CR(){
    const ThRow = () =>{
        alert("Caught the click")
    }
    return <button onClick={ThRow}>click</button>
}