import reducer from '../../futils/reducer';

// ------------------------------------
// Constants
// ------------------------------------
// Constants Here
// ------------------------------------
// Action Handlers
// ------------------------------------
const ACTION_HANDLERS = {
  GOTPOKEMON: (s, a) => ({
    pokemon: a.payload,
  }),
};

// ------------------------------------
// Reducer
// ------------------------------------
const initialState = {
  pokemon: [],
};

export default reducer(initialState, ACTION_HANDLERS);
