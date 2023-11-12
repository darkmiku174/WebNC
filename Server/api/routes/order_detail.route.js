var express = require('express');
var controller = require('../controllers/order_detail.controller');

var router = express.Router();

router.get('/', controller.index);

router.get('/:Id', async function (req, res) {
    var order_detail = await Order_detail.findById(req.params.Id);
    res.json(order_detail);
});
router.post('/', controller.create);

router.delete('/:Id', async function (req, res) {
    var order_details = await Order_detail.findByIdAndDelete(req.params.Id);
    res.json(order_details)
});

module.exports = router;