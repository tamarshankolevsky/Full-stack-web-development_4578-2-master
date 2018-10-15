// Requires:
const express = require("express"); 
const bodyParser = require("body-parser"); 
const country=require('./country');
const user=require('./user');

// Create express app:
const app = express();

// Use middlewares to get request's body as json:
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

// Add contreller rotes
country.addCountryRoutes(app);
user.addUserRoutes(app);

// Run server: 
app.listen(process.env.PORT || 3000, ()=>{
    console.log("Express Listening");
});
