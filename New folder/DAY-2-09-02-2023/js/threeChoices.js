let threeChoices = () =>{
    let name = document.getElementById('name').value.bold()
    var watched = "";
    var unWatched = "";
    let arr = []
    arr[0] = document.getElementById('superbad')
    arr[1] = document.getElementById('AmericanPsycho')
    arr[2] = document.getElementById('spartacus')
    for(i in arr){
        if(arr[i].checked === true){
            watched += " " + arr[i].value.bold() + ','
        }
        else{
            unWatched += " " + arr[i].value.bold() + ','
        }
    }
    document.getElementById('p').innerHTML = name + " has watched" + watched + " but not " + unWatched
}