import React from 'react';
import {connect} from 'react-redux';
import Field from '../../../Components/Field';


  class StepFilling extends React.Component{
    constructor(props){

        super(props);
        this.state={isChecked:this.props.isChecked}
    }
    // componentWillReceiveProps(nextProps) {
    //   if(nextProps.item !== this.props.item) {
    //     if(nextProps.item['FileWarrant'])
    //        this.setState({isChecked: true});
    //   }
    // }
    handleChange=(e)=>{

      this.setState({isChecked:!this.state.isChecked})
    }

    render(){

       const fields=[{accessor:'FileWarrant',Header:'تشکیل پرونده جهت اخذ حکم',type:'File',isRequired:'True'},{accessor:'DateFileWarrant',Header:'تاریخ تشکیل پرونده',type:'DateTime','isRequired':'True'}]
      return(<div>
       تشکیل پرونده جهت اخذ حکم <input type='checkbox' onChange={this.handleChange} checked={this.state.isChecked} />
         { this.state.isChecked?  <div >
          { fields.map((field,index)=><Field 
            key={field.accessor}
            internalName={field.accessor}
            storeIndex='WellViolations'
            formName={this.props.item[field.accessor]?'Edit':'New'}
            
          />)}
          </div>:null}
          </div>)
        
    }
  }
  const mapStateToProps=(state,props)=>({
    columns:state.columns['WellViolations'],item:state.item['WellViolations']
  })
  export default connect(mapStateToProps)(StepFilling)