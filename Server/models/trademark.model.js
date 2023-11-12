var mongoose = require('mongoose');

var trademarkSchema  = new mongoose.Schema({
   MaTH: String,
   TenTH: String,
   Logo: String,
   MoTa: String
});

var Trademark = mongoose.model('Trademarks', trademarkSchema, 'trademarks');

module.exports = Trademark;