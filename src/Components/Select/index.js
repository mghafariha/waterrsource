import React from 'react';
import {connect} from 'react-redux';
import {setFieldValue} from '../../store/action';

class Select extends React.Component{

    constructor(props)
    {
        super(props);
    }
    handleChange=(e)=>{

        if (this.props.multiple) {
            var options = e.target.options;
            var value = "";
            for (var i = 0, l = options.length; i < l; i++) {
                if (options[i].selected) {
                    value += (options[i].value) + ",";
                }
            }
            value.slice(0, -1);
            this.props.dispatch(setFieldValue(this.props.internalName,value))
        }
        else {
            this.props.dispatch(setFieldValue(this.props.internalName,e.target.value))
        }
    }
}
const mapStateToProps=(state)=>({item:state.item})
export default connect(mapStateToProps)(Select)
