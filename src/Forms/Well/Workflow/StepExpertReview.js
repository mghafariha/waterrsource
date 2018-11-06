import React from 'react';
import {connect} from 'react-redux';
import Field from '../../../Components/Field';


  class StepExpertReview extends React.Component{
    constructor(props){

        super(props);
        this.state={isChecked:this.props.isChecked}
    }
    // componentWillReceiveProps(nextProps) {
    //   if(nextProps.item !== this.props.item) {
    //     if(nextProps.item['CheckFile'])
    //        this.setState({isChecked: true});
    //   }
    // }
    handleChange=(e)=>{

      this.setState({isChecked:!this.state.isChecked})
    }

    render(){

       const fields=[{accessor:'CheckFile',Header:'فایل بررسی کارشناسی',type:'File',isRequired:'True'},{accessor:'DateCheckFile',Header:'تاریخ بررسی کارشناسی',type:'DateTime','isRequired':'True'}]
      return(<div>
      بررسی کارشناسی <input type='checkbox' onChange={this.handleChange} checked={this.state.isChecked} />
         { this.state.isChecked?  <div>
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
  export default connect(mapStateToProps)(StepExpertReview)