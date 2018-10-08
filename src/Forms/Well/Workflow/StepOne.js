import React from 'react';
import Field from '../../../Components/Field';

  class StepOne extends React.Component{
    constructor(props){

        super(props);
    }
    handleSubmit=(e)=>{

      // e.preventDefault();
           
     
    
      // updateItem(this.props.item).then((response)=>{
         
  
      //     this.props.dispatch(changeItem(this.props.item,this.props.storeIndex));
      //     //this.getTitle.value='';
      //   //  this.getDescription.value='';
      //    this.props.dispatch(setItem({},this.props.storeIndex));
  
      // }).catch((error)=>console.log(error));
  

    }

    render(){
       const fields=[{accessor:'FileFirstWarning',Header:'فایل اخطار اول',type:'File',isRequired:'True'},{accessor:'DateFirstWarning',Header:'تاریخ اخطار اول',type:'Date','isRequired':'True'}]
      return(<form onSubmit={this.handleSubmit} >
         { this.props.fields.map((field,index)=><Field 
          key={field.accessor}
          internalName={field.accessor}
          storeIndex='WellViolations'
          formName='New'
        
          />)}
          <button type='submit'>Submit</button>
      </form>)
        
    }
  }
  export default StepOne