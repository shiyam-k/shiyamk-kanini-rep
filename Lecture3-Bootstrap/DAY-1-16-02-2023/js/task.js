let elem = document.querySelector('.visible')

let evt1 = () => {
    let home = document.querySelector('#home')
    let about = document.querySelector('#about')
    if(home.classList.contains('visible') || about.classList.contains('hidden')){
        about.classList.add('visible')
        about.classList.remove('hidden')
        home.classList.remove('visible')
        home.classList.add('hidden')
        console.log(about.classList);
        console.log(home.classList);
    }
}
let evt2 = () =>{
    let home = document.querySelector('#home')
    let about = document.querySelector('#about')
    if(home.classList.contains('hidden') || about.classList.contains('visible')){
        home.classList.remove('hidden')
        home.classList.add('visible')
        about.classList.add('hidden')
        about.classList.remove('visible')
        console.log(about.classList);
        console.log(home.classList);
    }
}
