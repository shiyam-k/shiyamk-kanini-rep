let alertWindow = () =>{
    let books = (document.getElementById('books').value).split(',')
    console.log(books);
    let err = document.getElementById('err')
    if(books.length != document.getElementById('quantity').value ){
        err.innerHTML = "Books count and quantity doesnt match"
    }
    else{
        window.alert('the books are submitted')
        window.location.reload()
    }
}
