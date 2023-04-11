let a = document.querySelectorAll('.ni')

// for(i = 0; i<a.length; i++){
//     if(a[i].firstElementChild === null){
//         continue
//     }
// }
let active;

let act = (e) => {
    // if(a.firstElementChild === null){
    //console.log(e.hasAttribute('active'));
    // }
    // else{
    //     if(active > -1){
    //         a[active].firstElementChild.classList.remove('active')
    //     }
    //     console.log(a.firstElementChild);
    // }
    //console.log(e.parentElement.firstElementChild);
    if(!(e.hasAttribute('active'))){
        // for(i = 0; i<a.length; i++){
        //     if(a[i].firstElementChild.hasAttribute('active')){
        //         active = i
        //         //console.log(active);
        //         break;
        //     }
        // }
        
         
        
        if(active > -1){
            a[active].firstElementChild.classList.remove('active')
        }   

        {
            e.parentElement.firstElementChild.setAttribute('class','active')
        }       
         //console.log(e.parentElement.firstElementChild.classList);
        for(i = 0; i<a.length; i++){
            if(e == a[i].firstElementChild){
                active = i
                console.log(active);
                break;
            }
        }
        // console.log(e.parentElement)
        // console.log(e.parentElement.classList[2].toString() === 'nav-item')

        /*
        if(e.parentElement.classList[2].toString() === 'nav-item'){
            //console.log(document.querySelectorAll('.drop-item'))
            let dr = document.querySelectorAll('.drop-item')
            for(i = 0; i<dr.length; i++){
                console.log(dr[i].lastElementChild);
                if(dr[i].classList[1].toString() === 'drop-item' ){
                    //console.log(dr[i].firstElementChild.removeAttribute('data-bs-toggle'))
                    dr[i].firstElementChild.removeAttribute('data-bs-target')
                    //dr[i].lastElementChild.removeAttribute()
                }
                
            }
        }

        */
        // console.log(e);
        // console.log(a[0]);
        // console.log(e == a[0].firstElementChild)
    //console.log(e.hasAttribute('active'));
    }
    // else {
    //     e.classList.remove('active')
    //     //console.log(e.hasAttribute('active'));
    // }
}
let act2 = (e) =>{
    //console.log(e.parentElement.parentElement.lastElementChild.hasClass)
    if(active > -1){
    console.log(a[active].firstElementChild.classList.remove('active'))
    }
    if(!(e.hasAttribute('active'))){
        //console.log(e.parentElement)
        if(e.parentElement.classList[1].toString() === 'drop-item'){
            //console.log(e.parentElement.lastElementChild.firstElementChild.firstElementChild);
            e.parentElement.lastElementChild.firstElementChild.firstElementChild.firstElementChild.setAttribute('class', 'active')
        }
        else if(e.parentElement.classList[0].toString() === 'nav-item-2'){
            console.log(e.parentElement.firstElementChild.firstElementChild)
            e.parentElement.firstElementChild.firstElementChild.setAttribute('class','active')
            e.parentElement.parentElement.firstElementChild.firstElementChild.firstElementChild.classList.remove('active')
        }
        else if(e.parentElement.classList[0].toString() === 'nav-item-1'){
            console.log(e.parentElement.parentElement.lastElementChild.firstElementChild.firstElementChild)
            e.parentElement.firstElementChild.firstElementChild.setAttribute('class', 'active')
            e.parentElement.parentElement.lastElementChild.firstElementChild.firstElementChild.classList.remove('active')
            // e.parentElement.firstElementChild.firstElementChild.setAttribute('class','active')
            // e.parentElement.parentElement.firstElementChild.firstElementChild.firstElementChild.classList.remove('active')

        }
    }
}
