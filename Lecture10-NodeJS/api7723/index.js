console.log('hola desperado!')
const express = require('express')

const app = express()

app.get('/', function(req, res){
    res.json({greet:"hola desperado!"})
})

app.listen(3000)
