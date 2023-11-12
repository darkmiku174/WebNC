var mongoose = require('mongoose');

var orderSchema  = new mongoose.Schema({
   MaDH: String,
   NgayBan: String,
   MaCTDH: String,
   TrangThai: Number
});

var Order = mongoose.model('Orders', orderSchema, 'orders');

module.exports = Order;