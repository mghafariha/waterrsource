import React from 'react'
import { connect } from 'react-redux'
import moment from 'moment-jalaali';
import { setFieldValue } from '../../store/action'
import { isMoment } from 'moment-jalaali';

// import './calender.css'

class Date extends React.Component {
    constructor(props)
    {
        super(props); 
        this.state = { date:null};
    }
    componentWillReceiveProps=(nextProps)=> {
      if(nextProps.value !== this.props.value &&  nextProps.value) {
        this.setState({date:nextProps.value});
      }
    }
    componentDidUpdate(prevProps, prevState) {
        if (this.props.value != prevProps.value) {
            this.setState({date: this.props.value});
        }
      }
    Change=(unix, formatted)=>{
       console.log('unix',unix) // returns timestamp of the selected value, for example.
       this.props.dispatch(setFieldValue(this.props.internalName,moment(formatted,'jYYYY/jMM/jDD').toISOString(),this.props.storeIndex));
        // console.log('formatted',formatted) // returns the selected value in the format you've entered, forexample, "تاریخ: 1396/02/24 ساعت: 18:30".
        this.setState({date:formatted})
    }
   
    
     componentWillMount(){

          this.setState({date:this.props.value});
         
    // this.props.dispatch(setFieldValue(this.props.internalName,this.state.options[0].ID,this.props.storeIndex));
  
      }

    
    render() {
        const { value } = this.state;
        
       let value2=this.props.item[this.props.internalName];
      return this.props.render({internalName:this.props.internalName,value,onChange:this.Change})
    }
}
const mapStateToProps =(state,props)=> 
(
 {item:state.item[props.storeIndex],
    field:state.columns[props.storeIndex].find((field)=>field.accessor==props.internalName),
   value:state.item[props.storeIndex][props.internalName]?moment(state.item[props.storeIndex][props.internalName]).format('jYYYY/jMM/jDD'):undefined
     //  value:state.item[props.storeIndex][props.internalName]
})

export default connect(mapStateToProps)(Date)