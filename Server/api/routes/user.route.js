var express = require('express');
var controller = require('../controllers/user.controller');

var router = express.Router();

router.get('/', controller.index);

router.get('/:Id', async function (req, res) {
    var user = await User.findById(req.params.Id);
    res.json(user);
});
router.post('/', controller.create);

router.delete('/:Id', async function (req, res) {
    var users = await User.findByIdAndDelete(req.params.Id);
    res.json(users)
});

module.exports = router;