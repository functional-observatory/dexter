import { call, put, takeLatest, select, all } from 'redux-saga/effects'; //eslint-disable-line
import actionSpreader from '../utils/actionspreader';
import request from '../utils/request';

export function* getPokemon() {
  yield put(actionSpreader('GETTINGPOKEMON'));
  const hash = yield select(state => state.location.hash);
  const pokehash = hash.split('/')[2];
  const pokemon = yield call(
    request,
    `
  http://localhost:8000/xorigin?api=https://pokeapi.bastionbot.org/v1/pokemon/${pokehash}`,
  );

  yield put(actionSpreader('GOTPOKEMON', pokemon.data));
}

export function* getRecents() {
  yield put(actionSpreader('GETTINGRECENTPOKEMON'));
  const hashes = [...Array(3).keys()].map(_ =>
    Math.floor(Math.random() * Math.floor(807)),
  );
  const recents = yield all(
    hashes.map(x =>
      call(
        request,
        `
http://localhost:8000/xorigin?api=https://pokeapi.bastionbot.org/v1/pokemon/${x}`,
      ),
    ),
  );
  yield put(
    actionSpreader('GOTRECENTPOKEMON', recents.map(x => x.data.first())),
  );
}

export function* rootSaga() {
  yield takeLatest('GETPOKEMON', getPokemon);
  yield takeLatest('GETRECENT', getRecents);
}

export default rootSaga;
