import React from 'react';
import {connect} from 'react-redux'
import { Checkbox } from '../../../../node_modules/antd';
import StepOne from './StepOne';
import StepSetComplain from './StepSetComplain';
import StepWarningTwo from './StepWarningTwo';
import StepExpertReview from './StepExpertReview';
import StepExeJudjOrder from './StepExeJudjOrder';
import StepFiling from './StepFiling';
import StepSetMinutes from './StepSetMinutes';
import StepExeSentence from './StepExeSentence';
import { updateItem } from '../../../api';
import {changeItem,setItem} from '../../../store/action';
import Loader from '../../../Components/Loader';


class WellWorkFlow extends React.Component{

 constructor(props){
    super(props);
    this.state={loading:true}

 }
 componentDidMount=(e)=>{
      // let itmId=getUrlVars()['ID'];
       this.props.dispatch(setItem(this.props.selectedItem,this.props.storeIndex));
       this.setState({loading:false})
       
   }
 handleSubmit=(e)=>{
     this.state.loading=true;
       e.preventDefault();
       console.log('saveWorkFlow',this.props.item);
       updateItem(this.props.item,this.props.storeIndex).then((response)=>{
        this.props.dispatch(changeItem(this.props.item,this.props.storeIndex));
       alert('اطلاعات با موفقیت بروزرسانی شد');
       this.props.dispatch(setItem({},this.props.storeIndex));
       if (!!this.props.closeAfterSave) {
        this.props.closeAfterSave();
      }
       }).catch(error=>console.log('error :',error))
 }
 render(){
     return ( <form onSubmit={this.handleSubmit}>
              <div className='warper-form'>
                    <div className="row-items"  >    
                        <StepOne isChecked={this.props.selectedItem['FileFirstWarning']?true:false}/>
                    </div>
                    <div className="row-items" >
                     <StepSetComplain  isChecked={this.props.selectedItem['DateFile'] ||false}  /> 
                    </div> 
                    <div className="row-items" >
                        <StepWarningTwo   isChecked={this.props.selectedItem['SecondWarningDate'] ||false}/>
                    </div>
                    <div className="row-items"  >
                        <StepExpertReview isChecked={this.props.selectedItem['DateCheckFile']||false}/>
                    </div>
                    <div className="row-items"  >
                        <StepExeJudjOrder isChecked={this.props.selectedItem['DateExecuteOrder'] ||false} />
                    </div>
                    <div className="row-items"  >
                        <StepFiling isChecked={this.props.selectedItem['DateFileWarrant'] ||false}/>
                    </div>
                    <div className="row-items"  >
                        <StepSetMinutes isChecked={this.props.selectedItem['DateClosed'] ||false}/>
                    </div>
                    <div className="row-items"  >
                        <StepExeSentence isChecked={this.props.selectedItem['DateEnforcement']||false}/>
                    </div>
                   
                </div>     
               <button type='submit'>ذخیره</button>
             </form>)
 }
}
const mapStateToProps=(state,props)=>({

 item:state.item[props.storeIndex]

})
export default connect(mapStateToProps)(WellWorkFlow)
