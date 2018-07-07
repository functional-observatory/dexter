const Lectro = require('@lectro/core');
const CommonUtilsEnhancer = require('@lectro/enhancer-commonutils');
const WebpackBar = require('webpackbar');

class ShinobiLectro extends Lectro {
  addWebpackBar() {
    return this.mutate(self =>
      self.webpackConfig.plugins.push(new WebpackBar({ name: 'Shinobi' })),
    );
  }
}

const lectro = new ShinobiLectro('web' /* Target */)
  .addWebpackBar()
  .use(CommonUtilsEnhancer);
module.exports = lectro;
