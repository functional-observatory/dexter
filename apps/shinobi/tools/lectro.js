const Lectro = require('@lectro/core');
const CommonUtilsEnhancer = require('@lectro/enhancer-commonutils');
const BuildUtilsEnhancer = require('@lectro/enhancer-buildutils');

const Shinobi = new Lectro('web' /* Target */);

Shinobi.use(BuildUtilsEnhancer)
  .addProgressBar({ name: "Rajat's Pokedex", color: 'blue' })
  .devtool('source-map')
  .use(CommonUtilsEnhancer);
module.exports = Shinobi;
