import React from 'react';
import {connect} from 'react-redux';
import {setFieldValue} from '../../store/action';
//import Files from 'react-files'
 
import {URL} from '../../api';

//import ReactUploadFile from 'react-upload-file';

class File extends React.Component{
  
  constructor(props){
        super(props);   
    }
    handleChange(info) {


      const reader = new FileReader();
      reader.onloadend = (obj) => {
        this.imageDataAsURL = obj.srcElement.result;
        const fileAsBinaryString = reader.result;
      };
      reader.readAsDataURL(info.file.originFileObj);
    this.props.dispatch(setFieldValue(this.props.internalName,reader.readAsDataURL(info.file.originFileObj),this.props.storeIndex));
      }
  
    render(){
        
      let value=this.props.item[this.props.internalName]||null;
        return this.props.render({internalName:this.props.internalName,value,onChange:this.handleChange})
    }

     
}
const mapStateToProps=(state,props)=>(console.log('itemFile',state.item[props.storeIndex]),
  
  {item:state.item[props.storeIndex],field:state.columns[props.storeIndex].find((field)=>field.accessor==props.internalName)})
export default connect(mapStateToProps)(File);
