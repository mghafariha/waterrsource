import React from 'react';
 const NumberWid=({value,internalName,onChange})=>(

    <input type='number'
           id={internalName}
           value={value}
           onChange={onChange}/>
 )
 export default NumberWid