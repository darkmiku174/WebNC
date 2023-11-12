var mongoose = require('mongoose');

var productSchema  = new mongoose.Schema({
    MaSP: String,
    TenSP: String,
    CPU: String,
    ManHinh: String,
    DoPhuMau: String,
    RAM: String,
    VGA: String,
    BoNhoLuuTru: String,
    Pin: String,
    CongKetNoi: String,
    CanNang: String,
    HeDieuHanh: String,
    MauSac: String,
    DonGia: String,
    MaTH: String,
    HinhAnh: String
});

var Product = mongoose.model('Products', productSchema, 'products');

module.exports = Product;