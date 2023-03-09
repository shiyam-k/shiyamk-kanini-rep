let printer = () =>{
    let num = document.querySelector('.text-b').value
    let res = document.querySelector('.res')
    for(i = 1; i<=parseInt(num); i++){
        if(i == 4){
            continue;
        }
        else if(i % 2 == 0){
            let p = document.createElement('p')
            p.innerHTML = i
            res.appendChild(p)
        }
    }
}