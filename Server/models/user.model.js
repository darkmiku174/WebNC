var mongoose = require('mongoose');

var userSchema  = new mongoose.Schema({
   TenTK: String,
   MK: String,
   HoTen: String,
   SDT: String,
   Email: String,
   Address: String
});

var User = mongoose.model('Users', userSchema, 'users');

module.exports = User;