import React from 'react'
import { connect } from 'react-redux'

import { setFieldValue } from '../../store/action'

// import './calender.css'

class Date extends React.Component {
    constructor(props)
    {
        super(props); 
    }
    handleChange=(e)=>{
       console.log('date',e);
        this.props.dispatch(setFieldValue(this.props.internalName,e));
        console.log('date value',e)
    }
    render() {
        let value=this.props.item[this.props.internalName]
        return this.props.render({internalName:this.props.internalName,value,onChange:this.handleChange})
    }
}
const mapStateToProps =(state)=> ({ item:state.item })

export default connect(mapStateToProps)(Date)