var Order_detail = require('../../models/order_detail.model');

module.exports.index = async function(req, res) {
  var order_details = await Order_detail.find();
  res.json(order_details);
};

module.exports.create = async function(req, res) {
  var order_detail = await Order_detail.create(req.body);
  res.json(order_detail);
};
