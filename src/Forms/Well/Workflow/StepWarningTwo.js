import React from 'react'
import {connect} from 'react-redux'
import Field from '../../../Components/Field';
class StepWarningTwo extends React.Component{

    constructor(props){
        super(props);
        this.state={isChecked:false}
    }
    // componentWillReceiveProps(nextProps) {
    //   if(nextProps.item !== this.props.item) {
    //     if(nextProps.item['FileSecondWarning'])
    //        this.setState({isChecked: true});
    //   }
    // }
    handleChange=(e)=>{

      this.setState({isChecked:!this.state.isChecked})
    }
    render(){
       
        const fields=[{accessor:'FileSecondWarning',Header:'فایل اخطار دوم',type:'File',isRequired:'True'},{accessor:'SecondWarningDate',Header:'تاریخ اخطار دوم',type:'DateTime','isRequired':'True'}]
        return(<div>
         اخطار دوم <input type='checkbox' onChange={this.handleChange} checked={this.state.isChecked} />
           { this.state.isChecked?  <div >
            { fields.map((field,index)=><Field 
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
export default connect(mapStateToProps)(StepWarningTwo)