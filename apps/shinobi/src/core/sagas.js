import { call, put, takeLatest } from 'redux-saga/effects'; //eslint-disable-line
import actionSpreader from '../utils/actionspreader';
import request from '../utils/request';

export function* getPokemon() {
  yield put(actionSpreader('GETTINGPOKEMON'));
  yield call(request, 'https://pokeapi.bastionbot.org/v1/pokemon/658');
  yield put(actionSpreader('GOTPOKEMON'));
}

export function* rootSaga() {
  yield takeLatest('GETPOKEMON', getPokemon);
}

export default rootSaga;
