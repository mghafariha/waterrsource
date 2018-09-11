import thunk from 'redux-thunk'
import {items,item,infractionItem} from './reducer'
import {
 combineReducers,
 createStore,
 applyMiddleware

} from 'redux';
const reducer=combineReducers({
    items,
    item,
    infractionItem
});
const store=createStore(reducer,applyMiddleware(thunk))
export default store