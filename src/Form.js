import React from 'react';


import AllItems from './Components/AllItems';
import ItemForm from './Components/ItemForm';


export class Form extends React.Component{
    render(){
        return (
            
        <div className='form'>
           
            <ItemForm/>
            <br/>
            <AllItems/>
            </div>
            
          
          )
    }
}
