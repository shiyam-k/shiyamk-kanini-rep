
console.log("HI")
var maxCourses = 3
function addCourse(){
    let courseList = document.getElementById('c')
    if(courseList.value == 'html' && maxCourses >0){
        var x = document.getElementById("c1");  
        x.remove(x.selectedIndex);  
        maxCourses--;
        let added = document.getElementById('added')
        added.innerHTML += x.value + " added to list."
        console.log(added.innerHTML)
    }
    else if(courseList.value == 'css' && maxCourses >0){
        var x = document.getElementById("c2");  
        x.remove(x.selectedIndex); 
        let added = document.getElementById('added')
        maxCourses--;
        added.innerHTML += x.value + " added to list."
        added += x.value + " added to list."
        console.log(added.innerHTML)
    }
    else if(courseList.value == 'js' && maxCourses >0){
        var x = document.getElementById("c3");  
        x.remove(x.selectedIndex);  
        let added = document.getElementById('added')
        maxCourses--;
        added.innerHTML += x.value + " added to list."
        added += x.value + " added to list."
        console.log(added.innerHTML)
    }
    else if(courseList.value == 'react' && maxCourses >0){
        var x = document.getElementById("c4");  
        x.remove(x.selectedIndex);  
        let added = document.getElementById('added')
        maxCourses--;
        added.innerHTML += x.value + " added to list."
        added += x.value + " added to list."
        console.log(added.innerHTML)
    }
    else if(courseList.value == 'angular' && maxCourses >0){
        var x = document.getElementById("c5");  
        x.remove(x.selectedIndex);  
        let added = document.getElementById('added')
        maxCourses--;
        added.innerHTML += x.value + " added to list."
        added += x.value + " added to list."
        console.log(added.innerHTML)
    }
    else if(courseList.value == 'typescript' && maxCourses >0){
        var x = document.getElementById("c6");  
        x.remove(x.selectedIndex);  
        let added = document.getElementById('added')
        maxCourses--;
        added.innerHTML += x.value + " added to list."
        added += x.value + " added to list."
        console.log(added.innerHTML)
    }
    else if(courseList.value == 'node' && maxCourses >0){
        var x = document.getElementById("c7");  
        x.remove(x.selectedIndex);  
        let added = document.getElementById('added')
        maxCourses--;
        added.innerHTML += x.value + " added to list."
        added += x.value + " added to list."
        console.log(added.innerHTML)
    }
}