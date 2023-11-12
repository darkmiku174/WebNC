require('dotenv').config();

var express = require('express');
var bodyParser = require('body-parser');
var mongoose = require('mongoose');

mongoose.connect(process.env.MONGO_URL);

var apiProductRoute = require('./api/routes/product.route');

var port = 5000;

var app = express();

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

app.use('/api/products', apiProductRoute);

app.listen(port, function() {
  console.log('Server listening on port ' + port);
});