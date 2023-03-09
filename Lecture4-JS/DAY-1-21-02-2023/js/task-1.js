function bigImg(x) {
    x.style.height = "80%";
    x.style.width = "80%";
    x.style.border = "5px solid blue"
 }
 
 function normalImg(x) {
    x.style.height = "50%";
    x.style.width = "50%";
    x.style.border = "none"

 }

 let tot = () =>{
    let res = parseInt(document.querySelector('.i1').innerText) * parseInt(document.querySelector('.p1').value) +
    parseInt(document.querySelector('.i2').innerText) * parseInt(document.querySelector('.p2').value) +
    parseInt(document.querySelector('.i3').innerText) * parseInt(document.querySelector('.p3').value) + 
    parseInt(document.querySelector('.i4').innerText) * parseInt(document.querySelector('.p4').value)
    document.querySelector('.tot').innerText = res;
 }