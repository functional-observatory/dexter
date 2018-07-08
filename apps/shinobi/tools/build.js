const lectro = require('./lectro');
const fs = require('fs-extra');
const path = require('path');

fs.copySync(
  path.resolve(process.cwd(), 'public'),
  path.resolve(process.cwd(), 'build'),
);

lectro.build();
