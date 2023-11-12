var express = require('express');
var controller = require('../controllers/trademark.controller');

var router = express.Router();

router.get('/', controller.index);

router.get('/:Id', async function (req, res) {
    var trademark = await Trademark.findById(req.params.Id);
    res.json(trademark);
});
router.post('/', controller.create);

router.delete('/:Id', async function (req, res) {
    var trademarks = await Trademark.findByIdAndDelete(req.params.Id);
    res.json(trademarks)
});

module.exports = router;