var express = require('express');
var controller = require('../controllers/product.controller');

var router = express.Router();

router.get('/', controller.index);

router.get('/:Id', async function (req, res) {
    var product = await Product.findById(req.params.Id);
    res.json(product);
});
router.post('/', controller.create);

router.delete('/:Id', async function (req, res) {
    var products = await Product.findByIdAndDelete(req.params.Id);
    res.json(products)
});

module.exports = router;