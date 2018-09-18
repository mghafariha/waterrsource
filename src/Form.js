import React from 'react';
import { Link, Route } from 'react-router-dom';


import Visit from './Forms/Well/Visit'


export class Form extends React.Component{
constructor(props){
    super(props);
}
    render(){
        return (
            <div>
            <ul>
          
            <li><Link to="/Visit">Visit </Link></li>
           
          </ul>
         
          <Route path="/Visit" component={Visit} />
          
          </div>
        // <div className='form'>
           
        //     {/* <ItemForm/> */}
        //     <br/>
        //     <Visit  />
        //     </div>
            
          
          )
    }
}
