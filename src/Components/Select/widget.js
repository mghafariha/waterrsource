import React from 'react';

const SelectWid=({value,internalName,multiple,options,onChange})=>(
    <select id={internalName}
           onChange={onChange}
           multiple={multiple}
           name={internalName}
    >
    {options.map((options,index)=>(<option key={index} value={opt} selected={value.indexOf(opt)!=-1?'selected':''} >{opt}</option>))}

    </select>
)
export default SelectWid