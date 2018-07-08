import { injectReducer } from '../../store/reducers';
import { injectSagas } from '../../store/sagas';
import actionspreader from '../../utils/actionspreader';

export default store => ({
  path: 'home',
  /*  Async getComponent is only invoked when route matches   */
  getComponent(nextState, cb) {
    /*  Webpack - use 'require.ensure' to create a split point
        and embed an async module loader (jsonp) when bundling   */
    require.ensure(
      [],
      require => {
        /*  Webpack - use require callback to define
          dependencies for bundling   */
        const Container = require('./container').default;
        const reducer = require('./reducer').default;
        const sagas = require('./sagas').default;
        /*  Add the reducer to the store on key 'counter'  */
        injectReducer(store, { key: 'home', reducer });
        injectSagas(store, sagas);
        store.dispatch(actionspreader('GETRECENT'));
        /*  Return getComponent   */
        cb(null, Container);

        /* Webpack named bundle   */
      },
      'home',
    );
  },
});
