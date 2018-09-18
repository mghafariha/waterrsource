import {ADD_ITEM,SET_ALL_ITEMS,SET_FIELD_VALUE,SET_ITEM,DELETE_ITEM,UPDATE_ITEM,SET_INFRACTION_FIELD_VALUE,SET_INFRACTION_ITEM,SET_COLUMNS,CHECKED_COLUMN} from './constant'

export const items=(state={'WellVisiteds':[]},action)=>{
    switch(action.type){
        case ADD_ITEM:
        return {...state,[action.index]:[...state[action.index],action.item]}
       case UPDATE_ITEM:
       return  {state,[action.index]:state[action.index].map(el=> el.ID === action.item.ID? action.item : el)}
        case SET_ALL_ITEMS:
        return Object.assign({},state,{[action.index]:action.data})   
        case DELETE_ITEM:
        return {...state,[action.index]:state[action.index].filter((itm,index)=>(itm.ID!=action.item.ID))}
       
        default:
        return state
    }
};
export const item=(state={'WellVisiteds':{}},action)=>{
    switch(action.type){
        case SET_FIELD_VALUE:
        return  {...state,[action.index]:{...state[action.index],[action.field.internalName]:action.field.value}}
        case SET_ITEM:
        return Object.assign({},state, {[action.index]:{...action.item}})
       
        default:
        return state
    }
};
 export const infractionItem=(state=[],action)=>{
     switch(action.type){
        case SET_INFRACTION_FIELD_VALUE:
        return {...state,[action.field.internalName]:[...action.field.value]}
        case SET_INFRACTION_ITEM:
        return {...state,...action.item}
        default:
        return state
     }
 };
 export const columns=(state={'WellVisiteds':[]},action)=>{

    switch(action.type){

        case SET_COLUMNS:
        return Object.assign({}, state, {[action.index]:action.columns})
        case CHECKED_COLUMN:
         let newState=state;
         return {...state,[action.index]:state[action.index].map((item,inx)=>(item.accessor!=action.internalName)?item:{...item,isChecked:action.isChecked})}
        default: 
        return state
    }
 };
