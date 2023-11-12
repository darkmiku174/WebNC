var express = require('express');
var controller = require('../controllers/order.controller');

var router = express.Router();

router.get('/', controller.index);

router.get('/:Id', async function (req, res) {
    var order = await Order.findById(req.params.Id);
    res.json(order);
});
router.post('/', controller.create);

router.delete('/:Id', async function (req, res) {
    var orders = await Order.findByIdAndDelete(req.params.Id);
    res.json(orders)
});

module.exports = router;