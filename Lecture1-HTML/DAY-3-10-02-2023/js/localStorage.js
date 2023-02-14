function fetch() {
    document.getElementById("setfname").innerHTML = JSON.parse(localStorage.getItem("txtValue"));
    document.getElementById("setsname").innerHTML = JSON.parse(localStorage.getItem("txtValue1"));
    document.getElementById("setage").innerHTML = JSON.parse(localStorage.getItem("txtValue2"));
}

