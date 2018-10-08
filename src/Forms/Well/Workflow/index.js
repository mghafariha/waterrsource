import React from 'react';
import {connect} from 'react-redux'
import { Checkbox } from '../../../../node_modules/antd';
import StepOne from './StepOne';
import StepTwo from './StepTwo';
import StepThree from './StepThree';
import { updateItem } from '../../../api';
import {changeItem,setItem} from '../../../store/action';


class WellWorkFlow extends React.Component{

 constructor(props){
    super(props);

 }
 handleSubmit=(e)=>{
       e.preventDefault();
       updateItem(this.props.item,this.props.storeIndex).then((response)=>{
        this.props.dispatch(changeItem(this.props.item,this.props.storeIndex));
      
       this.props.dispatch(setItem({},this.props.storeIndex));
       })
 }
 render(){
     return (<form onSubmit={this.handleSubmit}> yessssss
               <div>
                <Checkbox  />
                <StepOne/>
               </div>
              
               <div>
               <Checkbox  />
                <StepTwo/>
               </div> 
               <div>
               <Checkbox  />
                <StepThree/>
               </div>
               <button type='submit'>submit</button>
             </form>)
 }
}
const mapStateToProps=(state,props)=>({

item:state.item[props.storeIndex]

})
export default connect(mapStateToProps)(WellWorkFlow)
