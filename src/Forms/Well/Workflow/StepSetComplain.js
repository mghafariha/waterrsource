import React from 'react';
import {connect}from 'react-redux';
import Field from '../../../Components/Field';
class StepSetComplain extends React.Component{

    constructor(props){
        super(props);
        this.state={isChecked:this.props.isChecked}
    }
    // componentWillReceiveProps(nextProps) {
    //   if(nextProps.item !== this.props.item) {
    //     if(nextProps.item['MeetingFile'])
    //        this.setState({isChecked: true});
    //   }
    // }
    handleChange=(e)=>{
      this.setState({isChecked:!this.state.isChecked})
    }
    render(){
       
        const fields=[{accessor:'MeetingFile',Header:'فایل تنظیم شکواییه برای دادگاه',type:'File',isRequired:'True'},{accessor:'DateFile',Header:'تاریخ تنظیم شکواییه',type:'DateTime','isRequired':'True'}]
        return(<div>
         تنظیم شکواییه و پیگیری و اخذ دستور قضایی<input type='checkbox' onChange={this.handleChange} checked={this.state.isChecked} />
           { this.state.isChecked?  <div >
            {fields.map((field,index)=><Field 
              key={field.accessor}
              internalName={field.accessor}
              storeIndex='WellViolations'
              formName='New'
          
            />)}
            </div>:null}
            </div>)
    }
}
const mapStateToProps=(state,props)=>({
    columns:state.columns['WellViolations'],item:state.item['WellViolations']
  })
export default connect(mapStateToProps)(StepSetComplain)