import React from 'react';
import { hashHistory, Router } from 'react-router';
import { Provider } from 'react-redux';
import { Provider as ElementaryProvider } from '@elementary/components';
import PropTypes from 'prop-types';
import theme from '../utils/theme';

class App extends React.Component {
  /* eslint-disable */
  static propTypes = {
    store: PropTypes.object.isRequired,
    routes: PropTypes.object.isRequired,
  };
  /* eslint-enable */
  shouldComponentUpdate() {
    return false;
  }

  render() {
    return (
      <Provider store={this.props.store}>
        <ElementaryProvider theme={theme} style={{ height: '100%' }}>
          <Router history={hashHistory}>{this.props.routes}</Router>
        </ElementaryProvider>
      </Provider>
    );
  }
}

export default App;
