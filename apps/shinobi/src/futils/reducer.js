import { propOr, identity } from "ramda";

export default (initialState, handlers) => (state = initialState, action) =>
  propOr(identity, action.type, handlers)(state, action);
