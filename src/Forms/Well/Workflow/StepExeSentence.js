import React from 'react';
import {connect} from 'react-redux';
import Field from '../../../Components/Field';


  class StepExeSentence extends React.Component{
    constructor(props){

        super(props);
        this.state={isChecked:this.props.isChecked}
    }
    // componentWillReceiveProps(nextProps) {
    //   if(nextProps.item !== this.props.item) {
    //     if(nextProps.item['ExecutionFiles'])
    //        this.setState({isChecked: true});
    //   }
    // }
    handleChange=(e)=>{

      this.setState({isChecked:!this.state.isChecked})
    }

    render(){

       const fields=[{accessor:'ExecutionFiles',Header:'فایل های اجرای حکم(صورتجلسات وفیش های پرداخت جریمه و...)',type:'File',isRequired:'True'},{accessor:'SavingFiles',Header:'فایل های میزان صرفه جویی',type:'File',isRequired:'True'},{accessor:'DateEnforcement',Header:'تاریخ اجرای حکم',type:'DateTime','isRequired':'True'}]
      return(<div>
       اجرای حکم + فایل های صرفه جویی <input type='checkbox' onChange={this.handleChange} checked={this.state.isChecked} />
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
  export default connect(mapStateToProps)(StepExeSentence)