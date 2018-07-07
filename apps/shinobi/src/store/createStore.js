import {
  applyMiddleware,
  compose,
  createStore as createReduxStore
} from "redux";
import thunk from "redux-thunk";
import { hashHistory } from "react-router";
import createSagaMiddleware from "redux-saga";

import makeRootReducer from "./reducers";
import { updateLocation } from "./location";
import coreSaga from "../core/sagas";

const sagaMiddleware = createSagaMiddleware();
const createStore = (initialState = {}) => {
  // ======================================================
  // Middleware Configuration
  // ======================================================
  const middleware = [thunk, sagaMiddleware];

  // ======================================================
  // Store Enhancers
  // ======================================================
  const enhancers = [];
  let composeEnhancers = compose;

  if (__DEV__) {
    if (typeof window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ === "function") {
      composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__;
    }
  }

  // ======================================================
  // Store Instantiation and HMR Setup
  // ======================================================
  const store = createReduxStore(
    makeRootReducer(),
    initialState,
    composeEnhancers(applyMiddleware(...middleware), ...enhancers)
  );

  sagaMiddleware.run(coreSaga);
  store.asyncReducers = {};
  store.runSaga = sagaMiddleware.run;
  // To unsubscribe, invoke `store.unsubscribeHistory()` anytime
  store.unsubscribeHistory = hashHistory.listen(updateLocation(store));

  if (module.hot) {
    module.hot.accept("./reducers", () => {
      const reducers = require("./reducers").default;
      store.replaceReducer(reducers(store.asyncReducers));
    });
  }

  return store;
};

export default createStore;
