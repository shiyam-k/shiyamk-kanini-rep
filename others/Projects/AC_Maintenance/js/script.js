let bookAppointment = () =>{
    let acType = document.getElementById('acType').value
    let serviceType = document.getElementById('serviceType').value
    let yearlyMaintenance = document.getElementById('yearlyMaintenance').checked
    let result = document.getElementById('result')
    let maintenance = "without yearly maintenance"
    let serviceCharge = 0
    console.log(yearlyMaintenance)
    if(serviceType == "Cleaning"){
        serviceCharge = 500
    }
    else if(serviceType == "Repair"){
        serviceCharge = 1000
    }
    else if(serviceType == 'Gas Refill'){
        serviceCharge = 1500
    }
    if(yearlyMaintenance == true){
        maintenance = "with yearly maintenance"
        serviceCharge += 1000
    }
    result.innerText = "Hello " + document.getElementById('customerName').value + " your service appointment for " + acType + " AC " + serviceType + " "+ maintenance + " will be sent to your email " + document.getElementById('email').value + " and the estimated service charge will be rs." + serviceCharge
}
let clearAll = () =>{
    
}