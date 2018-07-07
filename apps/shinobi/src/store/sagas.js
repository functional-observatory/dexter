export const injectSagas = (store, sagas) => sagas.map(store.runSaga); // eslint-disable-line
