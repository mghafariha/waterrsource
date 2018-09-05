import React from 'react';
import {connect} from 'react-redux';
import { setFieldValue } from '../../store/action';
class Number extends React.Component {

    constructor(props) {
        super(props);
        this.state={value:''}
    }
    // if not arrow function you should bind handleChange in constructor => this.handleChange =  this.handleChange.bind(this)
    handleChange=(e)=>{
       this.props.dispatch(setFieldValue(this.props.internalName,e.target.value));
    }
   
        render() {
            let value=this.props.item[this.props.internalName];
            return this.props.render({value,internalName:this.props.internalName,onChange:this.handleChange})
        } 
}
const mapStateToProps=(state)=>({item:state.item})
export default connect(mapStateToProps)(Number)