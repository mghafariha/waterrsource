import React from 'react';
import {connect} from 'react-redux';
import {setFieldValue} from '../../store/action';
//import Files from 'react-files'
// import { Upload, message, Button, Icon } from 'antd';
import ReactDropzone from 'react-dropzone';
import {URL,uploadFile} from '../../api';
import $ from 'jquery';

//import ReactUploadFile from 'react-upload-file';

class File extends React.Component{
  
  constructor(props){
        super(props); 
        this.state={file:''}  
    }
    componentDidMount(){

      let field=this.props.field;
         this.setState({file:this.props.value});
  }
    handleChange=(e)=>
    {
          let file= e.target.files[0];
        //   const reader = new FileReader();
        //  reader.onload = () => {
        //      const fileAsBinaryString = reader.result;
        //      // do whatever you want with the file content
        //  };
        //  reader.onabort = () => console.log('file reading was aborted');
        //  reader.onerror = () => console.log('file reading has failed');
 
        //  reader.readAsBinaryString(file);
        //  uploadFile(reader)



         this.fileList = []
         let getFile = getFileBuffer(file);
         let Title = file.name.substring(0,file.name.lastIndexOf('.'));
         let fileExtention = file.name.substring(file.name.lastIndexOf('.')+1, file.name.length) || Title;
         let FileName =Title+ '.' + fileExtention
         let Content='';
             getFile
                 .then(arrayBuffer => {
                      Content = arrayBuffer.split('base64,')[1]
                     this.fileList = [{ name: Title, url: '' }]
                    //  this.$emit('change', { FileName, Title, Content })
                     let filesave=[{FileName,Title,Content}];
                     uploadFile(filesave).then((result)=>{
                       console.log('ok');
                       this.props.dispatch(setFieldValue(this.props.internalName,result.data,this.props.storeIndex))

                     }).catch((error)=>console.log('error',error));
                    
                 })
               
                 
    }
    render(){
     
      return(<div>
         <input type="file"  onChange={this.handleChange}/>
              { this.props.value!=''? <a href={this.props.value}>{this.props.field.Header}</a>:''}
      </div>)
    }
}

const getFileBuffer = data => {
  var deferred = $.Deferred();
  var reader = new FileReader();
  reader.onloadend = function (e) {
      deferred.resolve(e.target.result);
  }
  reader.onerror = function (e) {
      deferred.reject(e.target.error);
  }
  reader.readAsDataURL(data);
  return deferred.promise();
}
const mapStateToProps=(state,props)=>(
  
  {item:state.item[props.storeIndex],field:state.columns[props.storeIndex].find((field)=>field.accessor==props.internalName),
    value:state.item[props.storeIndex][props.internalName]})
export default connect(mapStateToProps)(File);
