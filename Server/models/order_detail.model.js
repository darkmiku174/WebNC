var mongoose = require('mongoose');

var order_detailSchema  = new mongoose.Schema({
   MaCTDH: String,
   MaSP: String,
   SoLuong: Number
});

var Order_detail = mongoose.model('Order_details', order_detailSchema, 'order_details');

module.exports = Order_detail;