import React from 'react';
import {connect} from 'react-redux';
import {setInfractionFieldValue} from '../../../../store/action'


class CheckBox extends React.Component{

    constructor(props){
        super(props);
    }
    handleChange=(e)=>{
    this.props.dispatch(setInfractionFieldValue(this.props.internalName,e.target.checked))

    }

render(){
    let value=this.props.infractionItem[this.props.internalName];
    return this.props.render({value,internalName:this.props.internalName,onChange:this.handleChange})
}

}
const mapStateToProps=(state)=>({infractionItem:state.infractionItem})
export default connect(mapStateToProps)(CheckBox)

