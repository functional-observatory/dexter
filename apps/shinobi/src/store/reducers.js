import { combineReducers } from "redux";
import locationReducer from "./location";
import notifierReducer from "../connectors/notifier/reducer";

export const makeRootReducer = asyncReducers =>
  combineReducers({
    location: locationReducer,
    notify: notifierReducer,
    ...asyncReducers
  });

export const injectReducer = (store, { key, reducer }) => {
  if (Object.hasOwnProperty.call(store.asyncReducers, key)) return;

  store.asyncReducers[key] = reducer;
  store.replaceReducer(makeRootReducer(store.asyncReducers));
};

export default makeRootReducer;
