import {ADD_ITEM,SET_ALL_ITEMS,SET_FIELD_VALUE,SET_ITEM,DELETE_ITEM,UPDATE_ITEM,SET_INFRACTION_FIELD_VALUE,SET_INFRACTION_ITEM} from './constant';

export const addItem=(item)=>({

    type:ADD_ITEM,
    item
})
export const setAllItems=(data)=>({

    type:SET_ALL_ITEMS,
    data
})
export const setFieldValue=(internalName,value)=>({
type:SET_FIELD_VALUE,
field:{internalName,value}
})
export const setInfractionFieldValue=(internalName,value)=>({
type:SET_INFRACTION_FIELD_VALUE,
field:{internalName,value}

})
export const setInfractionItem=(item)=>({
    type:SET_INFRACTION_ITEM,
    item:item
})
export const setItem=(item)=>({
    type:SET_ITEM,
    item:item
})
export const deleteItem=(item)=>({
    type:DELETE_ITEM,
    item:item
})
export const changeItem=(item)=>({
    type:UPDATE_ITEM,
    item:item
})