var Order = require('../../models/order.model');

module.exports.index = async function(req, res) {
  var orders = await Order.find();
  res.json(orders);
};

module.exports.create = async function(req, res) {
  var order = await Order.create(req.body);
  res.json(order);
};
