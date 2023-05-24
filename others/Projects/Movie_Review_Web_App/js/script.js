let genre = {
    SciFi : ["Interstellar","Opennheimer","Ad Astra"]    
}
let movies = [
    {
        movieName:"No Record",
        director: "",
        cast:"",
        criticscore : '-',
        img : "./img/nodata.jpg"   
    },
    {
        movieName:"Glass",
        director: "Shyamalan",
        cast:"James McAvoy, Samuel L Jackson, Bruce Wills",
        criticscore : 70,
        img : "./img/glass.jpg"
    },
    {
        movieName:"Hey Ram",
        director: "Kamal Hasan",
        cast:"Kamal Hasan, Vasundhara Das, Rani Mukherjee",
        criticscore : 92,
        img : "./img/heyram.jpg"
    },
    {
        movieName:"Get Out",
        director: "Jordan Peele",
        cast:"Daniel Kaluuya, Allison Williams, Lakieth Stanfield",
        criticscore : 84,
        img : "./img/get out.png"
    },
    {
        movieName:"Krish",
        director: "Rakesh Roshan",
        cast:"Hrithik Roshan, Priyanka Chopra, Naseerdin Shah",
        criticscore : 81,
        img : "./img/krish.jpg"
    },
    {
        movieName:"Papanasam",
        director: "Jeethu Joseph",
        cast:"Kamal Hasan, Gauthami, Nivetha Thomas",
        criticscore : 76,
        img : "./img/Papanasam.jpg"
    },
    {
        movieName:"Blue Jay",
        director: "Alexandre Lehmann",
        cast:"Mark Duplass, Sarah Paulson, Clu Gulager",
        criticscore : 68,
        img : "./img/bj.jpg"
    },
    {
        movieName:"More Than Ever",
        director: "Emily Atef",
        cast:"Gaspard Ulliel, Vicki Krieps, Liv Ullmann",
        criticscore : 40,
        img : "./img/mte.jpg"
    },
    {
        movieName:"Her",
        director: "Spike Jonze",
        cast:"Joaquin Phoenix, Spike Jonze, Scarlett Johanson",
        criticscore : 85,
        img : "./img/her.jpg"
    },
    {
        movieName:"Vanilla Sky",
        director: "Cameron Crowe",
        cast:"Tom Cruise, Penelope Cruz, Cameron Diaz",
        criticscore : 82,
        img : "./img/vannillasky.jpg"
    },
    {
        movieName:"The Notebook",
        director: " Nick Cassavetes",
        cast:"Ryan Gosling, Rachel McAdams, James Gardener",
        criticscore : 79,
        img : "./img/thenotebook.jpg"
    },
    {
        movieName:"Interstellar",
        director: "Christopher Nolan",
        cast:"Matthew McConaughey, Jessica Hastain, Anne Hathaway",
        criticscore : 89,
        img : "./img/interstellar.jpg"
    },
    {
        movieName:"Ad Astra",
        director: "James Gray",
        cast:"Brad Pitt, Tommy Lee Jones, Ruth Negga",
        criticscore : 77,
        img : "./img/adastra.jpg"
    },
    {
        movieName:"Inception",
        director: "Christopher Nolan",
        cast:"LeoNardo Di Caprio, Joseph Gordon-Levitt, Cilian Murphy",
        criticscore : 92,
        img : "./img/inception.jpg"
    },
    {
        movieName:"The Current War",
        director: "Alfonso Gomez-Rejon",
        cast:"Benedict Cumberbatch, Nicholas Hoult, Tom Holland",
        criticscore : 87,
        img : "./img/currentwar.png"
    },
    {
        movieName:"The Matrix",
        director: "Lana Wachowski",
        cast:"Keanu Reeves, Carrie-Anne Moss, Lawrence Fishburne",
        criticscore : 95,
        img : "./img/matrix.jpg"
    },
]
    
/* Add Reviews about website*/
let addRev = () =>{
    let revArea = document.querySelector('.rev-area')
    let revText = document.querySelector('.rev-text').value
    console.log(revText)
    let newRev = document.createElement("div")
    let p = document.createElement("p")
    newRev.setAttribute("class", "carousel-item")
    p.setAttribute("class", "rev")
    let rev = document.createTextNode(revText)
    p.appendChild(rev)
    newRev.appendChild(p)
    revArea.appendChild(newRev)
    document.querySelector('.rev-text').value =""
}

/* Add Contents to Modal*/

let addContent = mName =>{
    let flag = false;
    mName = mName.trim();
    for(i = 0; i<movies.length; i++){
        if((mName).toLowerCase() === (movies[i].movieName).toLowerCase()){
            document.querySelector('.mt').innerText = movies[i].movieName
            document.querySelector('.poster').src = movies[i].img
            document.querySelector('.director').innerText = "Director: " + movies[i].director
            document.querySelector('.cast').innerText ="Cast: "+ movies[i].cast
            document.querySelector('.c-score').innerText ="Critic-Score: "+ movies[i].criticscore
            flag = true;
            break;
        }
    }
    if(flag == false){
        document.querySelector('.poster').src = movies[0].img
        document.querySelector('.mt').innerText = movies[0].movieName
    }
}
let clearOut = () =>{
    document.querySelector('.poster').src = "";
    document.querySelector('.director').innerText = ""
    document.querySelector('.cast').innerText = ""
    document.querySelector('.c-score').innerText = ""
}
var rating = 0;
const stars = document.querySelectorAll(".stars i");
stars.forEach((star, index1) => {
    let rate = 0
  star.addEventListener("click", () => {
    stars.forEach((star, index2) => {
      index1 >= index2 ? star.classList.add("active") : star.classList.remove("active");
      if(index1 >= index2 ){
        rate++;
      }
    });
    rating = rate
  });
 
});
let addComment = () =>{
    let p = document.createElement("p")
    let div = document.createElement('div')
    p.innerText = "@Dummy: "+ document.querySelector('#comment-box').value + " " + rating +"star rating"
    div.appendChild(p)
    div.setAttribute('class', "comment")
    document.querySelector('.cmt-area').appendChild(div)
}

let search = () =>{
    addContent(document.querySelector('.sfcss').value)
}

setTimeout(function(){
    swal({
title: "Get to the Movies Showcase",
text: "Click the button to have a look",
icon: "success",
showClass: {
    popup: 'animate__animated animate__fadeInDown'
  },
  hideClass: {
    popup: 'animate__animated animate__fadeOutUp'
  },
buttons: true,
})

.then((willNavigate) => {
// Check if the user clicked the button
if (willNavigate) {
// Navigate to the section
const section = document.querySelector('#hatchback');

// Scroll to the section element with smooth scrolling
section.scrollIntoView({
behavior: 'smooth',
block: 'start',
inline: 'nearest',

delay: 2000
});
}
});

},5000)



