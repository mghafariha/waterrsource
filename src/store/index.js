import thunk from 'redux-thunk'
import {items,item} from './reducer'
import {
 combineReducers,
 createStore,
 applyMiddleware

} from 'redux';
const reducer=combineReducers({
    items,
    item
});
const store=createStore(reducer,applyMiddleware(thunk))
export default store