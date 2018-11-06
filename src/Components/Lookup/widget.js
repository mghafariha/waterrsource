import React from 'react';

const LookupWid=({value,internalName,multiple,options,titleField,onChange,formName})=>(
    <select  disabled={formName=='Display'} value={value} onChange={onChange} multiple={multiple}  >
    {options.map((option, index) => (
        <option key={index} value={option.ID}>{option[titleField]}</option>
    ))}

    </select>

)
export default LookupWid


