function noAlph(evt) {             
    let nums = evt.keyCode
    document.getElementById('result').innerHTML = ""
    console.log(evt.which)
    if (nums > 31 && (nums < 48 || nums > 57))
        document.getElementById('result').innerHTML = "Enter a Number!"
        return false;
    return true;
}
let equal = () =>{
    let input1 = parseInt(document.getElementById('inp1').value)
    let input2 = parseInt(document.getElementById('inp2').value)
    let op = document.getElementById('op').value
    
    if(op == '+'){
        document.getElementById('result').innerHTML = input1 + input2
    }
    else if(op == '-'){
        document.getElementById('result').innerHTML = input1 - input2
    }
    else if(op == '*'){
        document.getElementById('result').innerHTML = input1 * input2
    }
    else if(op == '/'){
        document.getElementById('result').innerHTML = input1 / input2
    }  
    else{
        document.getElementById('result').innerHTML = "choose an operator"
    } 
}
function clearOut(){
    console.log("cleared");
    document.getElementById('inp1').value = ""
    document.getElementById('inp2').value = ""
    document.getElementById('op').value = ""
    document.getElementById('result').innerHTML = ""
}