import React from 'react';
import {connect} from 'react-redux';
import { setInfractionFieldValue } from '../../../../store/action';



class TextArea extends React.Component{

    constructor(props){
        super(props);
    }
    handleChange=(e)=>{
    this.props.dispatch(setInfractionFieldValue(this.props.internalName,e.target.value))

    }

render(){
    let value=this.props.infractionItem[this.props.internalName];
    return this.props.render({value,internalName:this.props.internalName,onChange:this.handleChange})
}

}
const mapStateToProps=(state)=>({infractionItem:state.infractionItem})
export default connect(mapStateToProps)(TextArea)