import reducer from '../../futils/reducer';

// ------------------------------------
// Constants
// ------------------------------------
// Constants Here
// ------------------------------------
// Action Handlers
// ------------------------------------
const ACTION_HANDLERS = {
  GOTRECENTPOKEMON: (s, a) => ({ ...s, recents: a.payload }),
  CHANGESEARCHTEXT: (s, a) => ({ ...s, searchText: a.payload }),
};

// ------------------------------------
// Reducer
// ------------------------------------
const initialState = {
  recents: [],
};

export default reducer(initialState, ACTION_HANDLERS);
