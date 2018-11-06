import React from 'react';
import {getItem} from '../../api';

class Span extends React.Component{

    constructor(props){
        super(props);
        this.state={value:''}
    }
    // componentDidMount=()=>{
    //     console.log('srcName',this.props.srcName);
    //     console.log('value',this.props.value);
    //     if(this.props.srcName && this.props.value)
    //     {
    //         getItem(this.props.value,this.props.srcName).then((result)=>{
        
    //             this.setState({value: result.data[this.props.titleField],lookup:true});
              
           
    //        }).catch(error=>console.log(error));
    //     }
        
            
        
    // }
    render (){
        return( <span>{this.props.value}</span>)
    }
}

export default Span;