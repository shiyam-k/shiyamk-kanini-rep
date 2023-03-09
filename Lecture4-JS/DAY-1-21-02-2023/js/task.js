

let printDay = () =>{
    var d = new Date();
    let day = d.getDay()
    let dayA;
    
    switch(day){
        case 1:
            document.querySelector('.h').innerHTML = "Today is " + "<h1>Monday</h1>"
            document.querySelector('.h').style.color = "blue"
            break;
        case 2:
            document.querySelector('.h').innerHTML = "Today is " + "<h1>Tuesday</h1>"
            document.querySelector('.h').style.color = "red"
            break;
        case 3:
            document.querySelector('.h').innerHTML = "Today is " + "<h1>Wednesday</h1>"
            document.querySelector('.h').style.color = "green"
            break;
        case 4:
            document.querySelector('.h').innerHTML = "Today is " + "<h1>Thursday</h1>"
            document.querySelector('.h').style.color = "grey"
            break;
        case 5:
            document.querySelector('.h').innerHTML = "Today is " + "Friday"
            document.querySelector('.h').style.color = "aqua"
            break;
        case 6:
            document.querySelector('.h').innerHTML = "Today is " + "Saturday"
            document.querySelector('.h').style.color = "purple"
            break;
        case 0:
            document.querySelector('.h').innerHTML = "Today is " + "Sunday"
            document.querySelector('.h').style.color = "blue"
            break;
    }
    
} 
var num = 1;
let getNumber = () =>{
    num = prompt('Give Number',num)
}
var res = 1;
let printFact = () => {
    if(num < 0){
        document.querySelector('.fact').innerText = "Enter positive value"
        document.querySelector('.fact').style.backgroundColor = "rgb(212, 70, 70)"
    }
    else if(num > 0){
        while(num  > 0){
            res *= num;
            num--;
        }
        document.querySelector('.fact').innerText = parseInt(res);
        document.querySelector('.fact').style.backgroundColor = "rgb(99, 207, 93)"
    }
    else{
        document.querySelector('.fact').innerText = `"`+num+`"`+" is Invalid input"
        document.querySelector('.fact').style.backgroundColor = "rgb(212, 70, 70)"
    }
    num = 1;
    
    res = 1;
}


let cl = () => {
    document.querySelector('.fact').innerText = "";
    document.querySelector('.ams').innerText = "";
}
let amsNum = () =>{
    let res = 0;
    let t1 = num
    if(num < 0){
        document.querySelector('.ams').innerText = "Enter positive value"
        document.querySelector('.ams').style.backgroundColor = "rgb(212, 70, 70)"
    }
    else if(num > 0){
        while(t1 > 0){
            let temp = t1 % 10;
            res += temp * temp * temp;
            t1 = parseInt(t1/10)
            console.log(res);
        }
        if(res == num){
            document.querySelector('.ams').innerText = `"` + num +`"` + "is Amstrong Number"
            document.querySelector('.ams').style.backgroundColor = "rgb(99, 207, 93)"
        }
        else{
            document.querySelector('.ams').innerText = `"` + num +`"` + "is not Amstrong Number"
            document.querySelector('.ams').style.backgroundColor = "rgb(212, 70, 70)"
    
    
        }
    }
    else{
        document.querySelector('.ams').innerText = `"`+num+`"`+" is Invalid input"
        document.querySelector('.ams').style.backgroundColor = "rgb(212, 70, 70)"   
    }
}