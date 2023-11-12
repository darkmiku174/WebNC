require('dotenv').config();

var express = require('express');
var bodyParser = require('body-parser');
var mongoose = require('mongoose');

mongoose.connect(process.env.MONGO_URL);

var apiProductRoute = require('./api/routes/product.route');
var apiOrderRoute = require('./api/routes/order.route');
var apiOrder_detailRoute = require('./api/routes/order_detail.route');
var apiTrademarkRoute = require('./api/routes/trademark.route');
var apiUserRoute = require('./api/routes/user.route');

var port = 5000;

var app = express();

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

app.use('/api/products', apiProductRoute);
app.use('/api/orders', apiOrderRoute);
app.use('/api/order_details', apiOrder_detailRoute);
app.use('/api/trademarks', apiTrademarkRoute);
app.use('/api/users', apiUserRoute);

app.listen(port, function() {
  console.log('Server listening on port ' + port);
});