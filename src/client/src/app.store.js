import {createStore, applyMiddleware} from 'redux';
import thunk from 'redux-thunk';
import rootReducer from './app.reducer';

const middlewares = [thunk];
const enhancer = applyMiddleware(...middlewares);
export default createStore(rootReducer, enhancer);
