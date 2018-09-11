import {ADD_ITEM,SET_ALL_ITEMS,SET_FIELD_VALUE,SET_ITEM,DELETE_ITEM,UPDATE_ITEM,SET_INFRACTION_FIELD_VALUE,SET_INFRACTION_ITEM} from './constant'

export const items=(state=[],action)=>{
    switch(action.type){
        case ADD_ITEM:
        return [...state,action.item]
       case UPDATE_ITEM:
       return state.map(el=> el.ID === action.item.ID? action.item : el)
        case SET_ALL_ITEMS:
        return [...state,...action.data]
        case DELETE_ITEM:
        return state.filter((item,index)=>item.ID!=action.item.ID)
        console.log('change item',state);
        default:
        return state
    }
};
export const item=(state={},action)=>{
    switch(action.type){
        case SET_FIELD_VALUE:
        return{...state,[action.field.internalName]:action.field.value}
        case SET_ITEM:
        return {...state,...action.item}
       
        default:
        return state
    }
};
 export const infractionItem=(state={},action)=>{
     switch(action.type){
        case SET_INFRACTION_FIELD_VALUE:
        return {...state,[action.field.internalName]:action.field.value}
        case SET_INFRACTION_ITEM:
        return {...state,...action.item}
        default:
        return state
     }
 }