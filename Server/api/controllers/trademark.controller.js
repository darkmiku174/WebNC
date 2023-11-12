var Trademark = require('../../models/trademark.model');

module.exports.index = async function(req, res) {
  var trademarks = await Trademark.find();
  res.json(trademarks);
};

module.exports.create = async function(req, res) {
  var trademark = await Trademark.create(req.body);
  res.json(trademark);
};
