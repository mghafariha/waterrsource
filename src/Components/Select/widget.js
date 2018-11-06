import React from 'react';
import Select from 'react-select'

const SelectWid=({value,internalName,multiple,options,onChange})=>(
    <Select id={internalName}
           onChange={onChange}
           isMulti={multiple}
           name={internalName} 
           options={options}
           placeholder='انتخاب ...'
           value={value}
           
    />
    //  <option value={null}>----</option>
    // {options.map((opt,index)=>(<option key={index} value={opt} selected={opt==value?'selected':''} >{opt}</option>))}

    // </select> 
)
export default SelectWid



